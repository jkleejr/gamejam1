using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreInc : MonoBehaviour
{
    private int score;
    public GameObject itemcollider;


    //sound for score when collision
    //[SerializeField] private AudioSource endGameSoundEffect;
    //[SerializeField] private AudioSource scoreUpSoundEffect;
    //[SerializeField] private AudioSource scoreDownSoundEffect;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Candy"))
        {
            //scoreUpSoundEffect.Play();

            score += 1;
            if (score > 0 && score % 5 == 0)
            {
                itemcollider.GetComponent<SpawnItems>().spawnerInterval -= 0.1f;
            }
        }
        else if (collision.CompareTag("BadItem"))
        {
            //scoreDownSoundEffect.Play();

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
            //send to game over screen scene, or display game over screen over main scene



        }

        //for losing game sound
        //endGameSoundEffect.Play();


        //can use for screen
        Debug.Log(score);
    }
}
