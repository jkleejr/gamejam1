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


    //sound for score when collision
    [SerializeField] private AudioSource endGameSoundEffect;
    [SerializeField] private AudioSource scoreUpSoundEffect;
    [SerializeField] private AudioSource scoreDownSoundEffect;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Candy"))
        {
            scoreUpSoundEffect.Play();

            score += 1;
            if (score > 0 && score % 5 == 0)
            {
                itemcollider.GetComponent<SpawnItems>().spawnerInterval -= 0.1f;
            }
        }
        else if (collision.CompareTag("BadItem"))
        {
            scoreDownSoundEffect.Play();

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
            endGameSoundEffect.Play();

            PlayerPrefs.SetInt("Score", score);
            Invoke("LoadScene", 0.2f);
        }

        //can use for screen
        scoreText.text = "Score:" + score.ToString();
    }

    void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
