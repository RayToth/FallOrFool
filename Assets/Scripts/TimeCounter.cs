using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeCounter : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    private string tooLateScene = "TooLate";
    public float timeRemaining = 60f;

    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timeText.text = "Time: " + Math.Round(timeRemaining).ToString();
        }
        else
        {
            timeRemaining = 0;
            SceneManager.LoadScene(tooLateScene);
        }
    }
}