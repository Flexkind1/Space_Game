using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    int startHigh;

   public void DeleteHighscore()
    {
        PlayerPrefs.DeleteAll();
        
    }


}
