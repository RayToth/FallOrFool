using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickupBeer : MonoBehaviour
{
    private GameObject time;
    private TimeCounter timeCounter;
    public float subtractTime = 3f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        time = GameObject.FindGameObjectWithTag("TimeText");
        timeCounter = time.GetComponent<TimeCounter>();
        timeCounter.timeRemaining -= subtractTime;
        Destroy(this.gameObject);
    }
}
