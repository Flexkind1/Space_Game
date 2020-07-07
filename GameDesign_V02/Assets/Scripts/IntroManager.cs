using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroManager : MonoBehaviour
{

    public GameObject Logbuch;
    public GameObject Rakete;
    public AudioSource Crash;
    public GameObject Fadeout;


    private void Awake()
    {
        
        
    }
    public void Weiter()
    {
        Logbuch.SetActive(false);
        Rakete.SetActive(true);
        Invoke("RaketeGeflogen", 2.5f);
        // RaketenAnim.Enabled();
        
      
    }


    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    void RaketeGeflogen()
    {
        Rakete.SetActive(false);
        Crash.Play();
        Fadeout.SetActive(true);
        Invoke("LoadMenu", 3.5f);
    }
   
}
