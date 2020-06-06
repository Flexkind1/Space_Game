using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePerSecond : MonoBehaviour
{
    public Text scoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSecond = 1f;
    }

    // Update is called once per frame
    void Update()
    {

        if (ScoringSystem.theScore < 20)
        {
            Scorelaeuft();
        }

        if (ScoringSystem.theScore >= 20)
        {
            Gewonnen();
        }


        void Scorelaeuft()
        {
            scoreText.text = (int)scoreAmount + " Score";
            scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
        }

        void Gewonnen()
        {
            scoreText.text = "Gewonnen";
        }
    }
}
