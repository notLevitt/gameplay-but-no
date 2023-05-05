using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;

    private float zSpawn = 12.0f;
    private float xSpawn = 16.0f;
    private float zPowerup = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        float randX = Random.Range(-xSpawn, xSpawn);
        int randIndex = Random.Range(0, enemies.Length);

        Vector3 spawn = new Vector3(randX, 0.75f, zSpawn);
        Instantiate(enemies[randIndex], spawn, enemies[randIndex].gameObject.transform.rotation);
    }
}
