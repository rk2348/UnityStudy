using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timerValue = 0f;

    void Update()
    {
        timerValue += UnityEngine.Time.deltaTime;

        Debug.Log(timerValue);
    }
}
