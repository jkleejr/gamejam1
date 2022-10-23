using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.SceneManagement;

//for game over screen

public class gameOver : MonoBehaviour
{
    
    public TMP_Text scoreText;
    void Start() 
    {
        scoreText.text = scoreText.text + PlayerPrefs.GetInt("Score").ToString();
    }
    
    public void Again()
    {
        PlayerPrefs.SetInt("Score", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //build settings - first scene index is 0, +1 to go to scene w/ index 1

    }

    public void QuitGame()
    {
        PlayerPrefs.SetInt("Score", 0);
        Application.Quit();

    }
}
