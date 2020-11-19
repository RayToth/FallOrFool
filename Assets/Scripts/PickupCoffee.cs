using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCoffee : MonoBehaviour
{

    private GameObject time;
    private TimeCounter timeCounter;
    public float additionalTime = 3f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        time = GameObject.FindGameObjectWithTag("TimeText");
        timeCounter = time.GetComponent<TimeCounter>();
        timeCounter.timeRemaining += additionalTime;
        Destroy(this.gameObject);
    }
}
