using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeHit : MonoBehaviour
{
    private string deathScene = "YouDied";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(deathScene);
    }
}
