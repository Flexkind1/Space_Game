/*using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class FinishDisplayScore : MonoBehaviour
{
    public Text score;
    public Text highScore;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }
    public void UpdateScore()
    {
        int number = "Gewonnen";
        score.text = number.ToString();

        PlayerPrefs.SetInt("Highscore", number);
    }
}*/
