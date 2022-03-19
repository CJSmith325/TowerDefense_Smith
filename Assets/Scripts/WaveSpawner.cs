using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab1;
    public Transform enemyPrefab2;
    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    private int waveNumber = 1;

    private void Update()
    {
        if (countdown <= 0)
        {
            SpawnWave();
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;
    }

    void SpawnWave()
    {
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
        }
        Debug.Log("Wave");
        waveNumber++;
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab1, spawnPoint.position, spawnPoint.rotation);
        Instantiate(enemyPrefab2, spawnPoint.position, spawnPoint.rotation);
    }
}
