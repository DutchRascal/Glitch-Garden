﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{

    [SerializeField] int lives = 5;
    [SerializeField] int timeToWait = 3;
    [SerializeField] int damage = 1;

    Text livesText;

    void Start()
    {
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void TakeLife()
    {
        if (lives >= damage)
        {
            lives -= damage;
            UpdateDisplay();
        }
        else
        {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        FindObjectOfType<LevelLoader>().LoadYouLose();
    }

}