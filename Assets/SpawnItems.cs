using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public float horizontalVariation;
    public GameObject[] items = new GameObject[8];

    private float totalTime;
    public float spawnerInterval;
    
    // Update is called once per frame
    void Update()
    {
        if (totalTime > spawnerInterval)
        {
            Vector3 SpawnPos = new Vector3(Random.Range(-horizontalVariation, horizontalVariation),
                transform.position.y, 0);
            
            GameObject spawnedItem = Instantiate(items[Random.Range(0, items.Length - 1)], SpawnPos, Quaternion.identity);
            totalTime = 0;
        }

        totalTime += Time.deltaTime;
    }
}
