using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level timers in SECONDS")]
    [SerializeField] float levelTime = 10f;

    void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;
        bool timerFinished = Time.timeSinceLevelLoad >= levelTime;
        if (timerFinished)
        {
            print("level timer expired");
        }
    }
}
