﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePerSecond : MonoBehaviour
{
    public static ScorePerSecond instance; //

    public Text scoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond;
    public static int EndScore;


    public int highScore; //

    void Awake()
    {
        instance = this;
    }


    //public HighScoreManager other;
   
    void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSecond = 1f;
        highScore = PlayerPrefs.GetInt("Highscore");
            
    }

    // Update is called once per frame
    void Update()
    {
        /*if (highScore < 1)
        {
            StartHighscore();
        }*/

        if (ScoringSystem.theScore < 2)
        {
            Scorelaeuft();
        }

        if (ScoringSystem.theScore >= 2)
        {
            Gewonnen();
            UpdateHighscore();
        }


        void Scorelaeuft()
        {
            scoreText.text = (int)scoreAmount + "Score";
            scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
        }

        void Gewonnen()
        {
            //scoreText.text = "Gewonnen";
            pointIncreasedPerSecond = 0f;
            EndScore = (int)scoreAmount;
            Debug.Log(EndScore);
            //other.UpdateHighscore();
            UpdateHighscore();

            PlayerPrefs.SetInt("Highscore", highScore);
            
           

        }

        void UpdateHighscore() //
        {

           if (EndScore < highScore)
            {
                highScore = EndScore;
            }

        }

        //void StartHighscore()
       // {
       //     highScore = 50;
        //}
    }
}
