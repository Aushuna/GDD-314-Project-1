using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabToSpawn;
    public Score score;
    public float spawnRate = 3;
    float spawnTime;

    void Start()
    {
        spawnTime = spawnRate; 
    }
    void Update()
    {
        if (spawnTime < 0)
        {

            //random number, determines what item in array spanws
            int whichprefab = Random.Range(0, /*prefabToSpawn.Length*/3);
            

            //spawns new ball prefab with a random color
            GameObject newBall = Instantiate(prefabToSpawn[whichprefab]);
            newBall.transform.position = transform.position;
            spawnTime = spawnRate;
        }

        spawnTime -= Time.deltaTime;
    }
 }
