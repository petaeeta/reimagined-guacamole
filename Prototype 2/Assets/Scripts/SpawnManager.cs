using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    private readonly float spawnRangeX = 10;
    private readonly float spawnRangeZ = 20;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, AnimalPrefabs.Length);
            Vector3 spawnPos = new(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

            Instantiate(AnimalPrefabs[animalIndex], spawnPos, AnimalPrefabs[animalIndex].transform.rotation);
        }
    }
}
