using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReachCodeCool : MonoBehaviour
{
    private string winMenu = "WinScene";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(winMenu);
    }
}
