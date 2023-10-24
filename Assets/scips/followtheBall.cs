using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followtheBall : MonoBehaviour
{
    public GameObject obgect;
    public GameObject ball;
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("sphere");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Instantiate(obgect, ball);
    }
}
