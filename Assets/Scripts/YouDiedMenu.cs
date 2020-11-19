using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouDiedMenu : MonoBehaviour
{
    private string gameScene = "Game";
    public void RetryGame()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

