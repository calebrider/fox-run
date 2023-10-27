using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text timerText;

    private float timeElapsed = 0f;
    private float timer = 0f;
    private bool stopTimer = false;
    private bool trophyReached = false;
    private string finalTime;

    // Update is called once per frame
    void Update()
    {
        if (!stopTimer)
        {
            timer += Time.deltaTime;
            timeElapsed = MathF.Round(timer, 2);
            timerText.text = "Time: " + timeElapsed;
        }

        finalTime = "Time: " + timeElapsed;
        timerText.text = finalTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trophy"))
        {
            stopTimer = true;
            trophyReached = true;
        }
    }

    private void OnDisable()
    {
        float previousHighScore = PlayerPrefs.GetFloat("highScore");

        PlayerPrefs.SetFloat("timeScore", timeElapsed);

        // New High Score
        if (trophyReached && previousHighScore == 0)
        {
            PlayerPrefs.SetFloat("highScore", timeElapsed);
        }
        else if (trophyReached && timeElapsed <= previousHighScore)
        {
            PlayerPrefs.SetFloat("highScore", timeElapsed);
        }
    }
}
