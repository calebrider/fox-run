using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text appleScoreText;
    [SerializeField] private Text timeScoreText;
    [SerializeField] private Text highScoreText;

    void OnEnable()
    {
        appleScoreText.text = "Apples: " + PlayerPrefs.GetInt("appleScore").ToString() + "/3";
        timeScoreText.text = "Time: " + PlayerPrefs.GetFloat("timeScore").ToString();
        highScoreText.text = "Best Time: " + PlayerPrefs.GetFloat("highScore").ToString();
    }
}
