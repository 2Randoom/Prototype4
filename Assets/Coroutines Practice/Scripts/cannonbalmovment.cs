using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonbalmovment : MonoBehaviour
{


    public Rigidbody cannonballRB;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        cannonballRB = GetComponent<Rigidbody>();
        cannonballRB.AddRelativeForce(Vector3.forward * force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
