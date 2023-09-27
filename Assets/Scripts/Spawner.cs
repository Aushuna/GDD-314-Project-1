using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabToSpawn;
    public GameObject YellowBin, PurpleBin;
    public Score score;
    public int array = 3;
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
            int whichprefab = Random.Range(0, array);
            
            //if score equeals a certain ammount add one more to the array and set object as active.
            if (score.GetCount() >= 5)
            {
                array = 4;
                YellowBin.gameObject.SetActive(true);
            }
            if (score.GetCount() >= 10)
            {
                array = 5;
                PurpleBin.gameObject.SetActive(true);
            }



            //spawns new ball prefab with a random color
            GameObject newBall = Instantiate(prefabToSpawn[whichprefab]);
            newBall.transform.position = transform.position;
            spawnTime = spawnRate;
        }

        spawnTime -= Time.deltaTime;
    }
 }
