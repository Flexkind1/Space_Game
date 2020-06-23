using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScorePerSecond : MonoBehaviour
{
    public static ScorePerSecond instance; //

    public TextMeshProUGUI scoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond;
    public static int EndScore;

    public TextMeshProUGUI HighscoreEndscreen;
    public TextMeshProUGUI YourScore;


    public int highScore; //

    void Awake()
    {
        instance = this;
    }


    //public HighScoreManager other;
   
    void Start()
    {
        scoreAmount = 500f;
        pointIncreasedPerSecond = -1f;
        highScore = PlayerPrefs.GetInt("Highscore"); 
       // highScore = PlayerPrefs.GetInt("Highscore", 500);
            
    }

    // Update is called once per frame
    void Update()
    {
        /*if (highScore < 1)
        {
            StartHighscore();
        }*/

        if (ScoringSystem.theScore < 15)
        {
            Scorelaeuft();
        }

        if (ScoringSystem.theScore >= 15)
        {
            Gewonnen();
            UpdateHighscore();
        }


        void Scorelaeuft()
        {
            scoreText.text = " Your Time: " + (int)scoreAmount;
            scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
        }

        void Gewonnen()
        {
            //scoreText.text = "Gewonnen";
            pointIncreasedPerSecond = 0f;
            EndScore = (int)scoreAmount;
            Debug.Log(EndScore);
            //other.UpdateHighscore();
            scoreText.text = "";
            HighscoreEndscreen.text = "" + PlayerPrefs.GetInt("Highscore");
            YourScore.text = "" + EndScore;

            UpdateHighscore();

            
            
           

        }

        void UpdateHighscore() //
        {

             if (EndScore > highScore)
            {
                highScore = EndScore;
                PlayerPrefs.SetInt("Highscore", highScore);
            }
           
           

            /* if (EndScore < highScore)
              {
                  highScore = EndScore;
              }*/

        }

        //void StartHighscore()
        // {
        //     highScore = 50;
        //}
    }
}
