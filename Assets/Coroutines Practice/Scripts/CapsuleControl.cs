using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleControl : MonoBehaviour
{
    //VARIABLES

    [Header("Movement")]
    public float moveSpeed;
    public float turnSpeed;
    public float jumpForce;
    public bool isOnGround = true;
    private float verticalInput;
    private float horizontalInput;
    private Rigidbody rb;

    [Header("Shooting")]
    public GameObject projectile;
    public float shootDelay;
    public GameObject spawnPoint;
    public bool canShoot = true ;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Forward and Backward Movement
        transform.Translate(Vector3.forward * moveSpeed * verticalInput * Time.deltaTime);
        

      

        //Clockwise and counterclockwise Rotation
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);


        
        //Jumping
        if (Input.GetKeyDown(KeyCode.Space)) 
         {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }




        //Shooting

        if (Input.GetKeyDown(KeyCode.Q)&& canShoot)
        {
            StartCoroutine(Shoot());

            //delay
           
        }


    }

    IEnumerator Shoot()
    {
        //wait
        canShoot = false;
        Instantiate(projectile, spawnPoint.transform.position, spawnPoint.transform.rotation);
        yield return new WaitForSeconds(shootDelay);
        canShoot =true; 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
