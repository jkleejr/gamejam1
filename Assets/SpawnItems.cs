using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public float horizontalVariation;
    public GameObject[] items = new GameObject[10];

    private float totalTime;
    public float spawnerInterval;
    
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        spawnerInterval = Mathf.Clamp(spawnerInterval, 0.3f, 1f);
        if (totalTime > spawnerInterval)
        {
            Vector3 SpawnPos = new Vector3(Random.Range(-horizontalVariation, horizontalVariation),
                transform.position.y, 0);
            
<<<<<<< HEAD
            GameObject spawnedItem = Instantiate(items[Random.Range(0, items.Length)], SpawnPos, Quaternion.identity);
=======
            GameObject spawnedItem = Instantiate(items[Random.Range(0, items.Length - 1)], SpawnPos, Quaternion.identity);
>>>>>>> 914a47520d81520cb0edb0f35e177a208207ea3a
            totalTime = 0;
        }

        totalTime += Time.deltaTime;
    }
}
