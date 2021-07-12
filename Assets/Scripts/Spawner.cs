using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code heavily inspired by Blackthornprod from YouTube
// https://www.youtube.com/watch?v=RZTpDxgrDkQ

public class Spawner : MonoBehaviour

{ 
    public GameObject enemy;
    public Transform[] spawnSpots;
    public float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public bool spawnBuildUp;

    // Start is called before the first frame update
    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnBuildUp)
        {
            // Spawn enemys in intervals based on what the developer put
            if (timeBtwSpawns <= 0)
            {
                int randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);
                timeBtwSpawns = startTimeBtwSpawns;
                if(startTimeBtwSpawns == 2)
                {
                    spawnBuildUp = false;
                }
                startTimeBtwSpawns--;
            }
            else
            {
                timeBtwSpawns -= Time.deltaTime;
            }
        }


        // Spawn enemys in intervals based on what the developer put
        if (timeBtwSpawns <= 0)
        {
            int randPos = Random.Range(0, spawnSpots.Length);
            Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
