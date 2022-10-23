using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreInc : MonoBehaviour
{
    private int score;
    public GameObject itemcollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Candy"))
        {
            score += 1;
            if (score > 0 && score % 5 == 0) 
            {
                itemcollider.GetComponent<SpawnItems>().spawnerInterval -= 0.1f;
            }
        }
        else if (collision.CompareTag("BadItem"))
        {
            if (score == 0) 
            {
                score = 0;
            }
            else
            {
                score -=1;
            }
        }
        else if (collision.CompareTag("VeryBadItem"))
        {
            Debug.Log("Game Over");
        }

        //can use for screen
        Debug.Log(score);
    }
}
