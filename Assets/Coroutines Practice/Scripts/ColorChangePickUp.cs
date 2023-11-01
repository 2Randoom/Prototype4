using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangePickUp : MonoBehaviour
{
    [Header("Materials")]
    public Material defaultMaterial;
    public Material newMaterial;

    [Header("Duration")]
    public float duration;

    //Components

    private MeshRenderer myMr;
    private MeshRenderer playerMr;
    private Collider myCollider;


    // Start is called before the first frame update
    void Start()
    {
        myMr = GetComponent<MeshRenderer>();
        myCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //check if its a player
        if (other.gameObject.CompareTag("Player"))
        {
            //get the player meshrender
            playerMr = other.gameObject.GetComponent<MeshRenderer>();

            //star the courutine
            StartCoroutine(colorChange());
        }
    }



    IEnumerator colorChange()
    {

        //change the coor 
        playerMr.material = newMaterial;
        //wait
        yield return new WaitForSeconds(duration);

        //change color back
        playerMr.material = defaultMaterial;
    }
}
