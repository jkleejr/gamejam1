using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreInc : MonoBehaviour
{
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Candy"))
        {
            score += 1;
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

        Debug.Log(score);
    }
}
