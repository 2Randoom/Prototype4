using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canoncontroler : MonoBehaviour
{

    public GameObject cannonball;
    public GameObject spawnpos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            shoot(5);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(SteadyShot(6, 0.5f));
        }
    }

    public void shoot(int numberOfBalls)
    {

        {
            Instantiate(cannonball, spawnpos.transform.position, spawnpos.transform.rotation);
           
        }

    }
    IEnumerator SteadyShot(int numberOfBalls,float delay)
    {
        for (int i = 0; i < numberOfBalls; i++)
        {
            Instantiate(cannonball, spawnpos.transform.position, spawnpos.transform.rotation);
            yield return new WaitForSeconds(delay);
        }
    }
}
