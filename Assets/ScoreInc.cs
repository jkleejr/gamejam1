using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.SceneManagement;

public class ScoreInc : MonoBehaviour
{
    public TMP_Text scoreText;
    
    public int score;
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
            PlayerPrefs.SetInt("Score", score);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        //can use for screen
        scoreText.text = "Score:" + score.ToString();
    }
}
