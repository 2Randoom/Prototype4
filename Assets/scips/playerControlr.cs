using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControlr : MonoBehaviour
{

    private Rigidbody playerRB;
    public float speed;
    private GameObject focalPoint;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("focalpoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");

        playerRB.AddForce(focalPoint.transform.forward * forwardInput * speed);
    }

}
