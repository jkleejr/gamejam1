using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public float horizontalVariation;
    public GameObject candy1, candy2, candy3, candy4;
    public GameObject[] candies = new GameObject[4];

    private float totalTime;
    public float spawnerInterval;
    
    void Start()
    {
        candies[0] = candy1;
        candies[1] = candy2;
        candies[2] = candy3;
        candies[3] = candy4;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (totalTime > spawnerInterval)
        {
            Vector3 SpawnPos = new Vector3(Random.Range(-horizontalVariation, horizontalVariation),
                transform.position.y, 0);
            
            GameObject spawnedItem = Instantiate(candies[Random.Range(0, 3)], SpawnPos, Quaternion.identity);
            totalTime = 0;
        }

        totalTime += Time.deltaTime;
    }
}
