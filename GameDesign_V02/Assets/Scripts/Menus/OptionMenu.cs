using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    int startHigh;
    public AudioSource Hover;

   public void DeleteHighscore()
    {
      // PlayerPrefs.DeleteAll();
      PlayerPrefs.SetInt("Highscore", 0);


    }

    public void OnMouseEnter()
    {
        Hover.Play();
    }
}
