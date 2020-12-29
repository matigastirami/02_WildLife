using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemies;

    private int animalIndex = 0;

    private float spawnRangeX = 20f;

    private float spawnPositionZ;

    [SerializeField, Range(2, 10)]
    private float startDelay = 2f;

    [SerializeField, Range(0.1f, 5f)]
    private float spawnInterval = 1.5f;

    private void Start()
    {
        spawnPositionZ = transform.position.z;
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    
    private void SpawnRandomAnimal()
    {
        // Generar posición donde aparece el próximo enemigo
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);

        Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, enemies[animalIndex].transform.rotation);
    }
}
