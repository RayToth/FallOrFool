using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    private string gameScene = "Game";
    public void PlayGame()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
