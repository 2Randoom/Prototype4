using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enimy : MonoBehaviour
{
    public float speed = 1.5f;
    private Rigidbody enemyRb;
    private GameObject player;
    public GameObject suziHead;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }


        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection *speed) ;

        suziHead.transform.position = transform.position;
    }
}
