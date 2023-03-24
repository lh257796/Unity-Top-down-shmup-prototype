using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //this creates animalPrefabs array
    private float spawnRangeX = 10;
    private float spawnPosZ = 30;
    // Start is called before the first frame update
    private float startDelay = 2;
    private float spawnInterval = 1.1f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        // spawns animals via callback of method, at intervals, with a delay
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal() {
        //void says that this method does not return anything

        //random index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            // position is a random range between -X and X, y=0, and at the top of the screen with Z

        int animalIndex = Random.Range(0, animalPrefabs.Length);
            // don't forget Length is capital in C#...

        Instantiate(animalPrefabs[animalIndex], spawnPos,
        animalPrefabs[animalIndex].transform.rotation);
            // rotation is to make sure animal is facing the right way; animalIndex value is [0] default
    }
}
