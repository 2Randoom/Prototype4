using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControlr : MonoBehaviour
{

    private Rigidbody playerRB;
    public float speed;
    private GameObject focalPoint;
    public bool hasPowerUp = false;
    public bool hasparticle = false;
    private float Powerupstranthe = 15.0f;
    public GameObject PowerupinDicator;
    public ParticleSystem particlesystem;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("focalpoint");
        particlesystem.Stop();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float forwardInput = Input.GetAxis("Vertical");

        PowerupinDicator.transform.position = transform.position;

        playerRB.AddForce(focalPoint.transform.forward * forwardInput * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("powerUP"))
        {
            hasPowerUp = true;
            PowerupinDicator.gameObject.GetComponent<MeshRenderer>().enabled = true;
            Destroy(other.gameObject);
            particlesystem.Play();
            StartCoroutine(powerUpcountdown());
           
        }
    }
    IEnumerator powerUpcountdown()
    {
      yield return new WaitForSeconds(7);
        hasPowerUp = false;
        PowerupinDicator.gameObject.GetComponent<MeshRenderer>().enabled = false;
        // PowerupinDicator.gameObject.SetActive(false);
        particlesystem.Stop();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enimy")&& hasPowerUp)
        {
            Debug.Log("collided wihth" + collision.gameObject.name + "withpoweUP set to " + hasPowerUp);
            Rigidbody enemyRigedbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayfromplayer = (collision.gameObject.transform.position - transform.position);
            enemyRigedbody.AddForce(awayfromplayer * Powerupstranthe, ForceMode.Impulse);
        }
    }

}
