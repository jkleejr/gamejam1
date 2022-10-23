using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public float horizontalVariation;
    public GameObject[] items = new GameObject[10];

    private float totalTime;
    public float spawnerInterval;

    private Vector2 screenBounds;
    
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    
    // Update is called once per frame
    void Update()
    {
        spawnerInterval = Mathf.Clamp(spawnerInterval, 0.3f, 1f);
        if (totalTime > spawnerInterval)
        {
            Vector3 SpawnPos = new Vector3(Random.Range(screenBounds.x * -1 + 1, screenBounds.x - 1),
                transform.position.y, 0);
            
            GameObject spawnedItem = Instantiate(items[Random.Range(0, items.Length)], SpawnPos, Quaternion.identity);
            totalTime = 0;
        }

        totalTime += Time.deltaTime;
    }
}
