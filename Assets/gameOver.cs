using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

//for game over screen

public class gameOver : MonoBehaviour
{
    public void Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        //build settings - first scene index is 0, +1 to go to scene w/ index 1

    }

    public void QuitGame()
    {
        Application.Quit();

    }
}
