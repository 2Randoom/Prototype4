using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmaniger : MonoBehaviour
{
    public int enemyCount;
    public GameObject enemyPrefab;
    private float spawnRange = 9f;
    public int waveNumber;
    public GameObject powerUp;

    // Start is called before the first frame update
    void Start()
    {

        spawnEnemyWave(waveNumber);

       // Instantiate(powerUp, GenrateSpaenpos(), powerUp.transform.rotation);


    }

    void spawnEnemyWave(int enemiestoSpawn)
    {
        for (int i = 0; i < enemiestoSpawn; i++)
        {
            Instantiate(enemyPrefab, GenrateSpaenpos(), enemyPrefab.transform.rotation);

        }

    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsByType<enimy>(0).Length;

        if(enemyCount == 0 || Input.GetKeyDown(KeyCode.P))
        {
            waveNumber++;
            spawnEnemyWave(waveNumber);
            Instantiate(powerUp, GenrateSpaenpos(), powerUp.transform.rotation);
        }
    }

    private Vector3 GenrateSpaenpos()
    {
        float spawnposX = Random.Range(-spawnRange, spawnRange);
        float spawnposZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randompos = new Vector3(spawnposX, 0, spawnposZ);

        return randompos;
    }
}
