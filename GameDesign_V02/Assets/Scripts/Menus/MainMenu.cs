using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI highscoreText;
    public GameObject Fade;
    public AudioSource ButtonHover;
    public AudioSource ButtonClick;

    void Start()
    {
        highscoreText.text = "Highscore " + PlayerPrefs.GetInt("Highscore");
        Invoke("FadeIn", 1.3f);
       // ButtonHover = GetComponent<AudioSource>();
    }
    public void PlayGame ()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    void FadeIn()
    {
        Fade.SetActive(false);
    }
    public void OnMouseEnter()
    {
       
        ButtonHover.Play();
    }

    
}
