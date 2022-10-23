using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

//for main menu screen

public class gameStart : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //build settings - first scene index is 0, +1 to go to scene w/ index 1

        //main game scene should be 1
        //game over screen should be 2
    }

    public void QuitGame()
    {
        Application.Quit();

    }
}
