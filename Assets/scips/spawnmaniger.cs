using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmaniger : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9f;

    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate( enemyPrefab,GenrateSpaenpos(), enemyPrefab.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenrateSpaenpos()
    {
        float spawnposX = Random.Range(-spawnRange, spawnRange);
        float spawnposZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randompos = new Vector3(spawnposX, 0, spawnposZ);

        return randompos;
    }
}
