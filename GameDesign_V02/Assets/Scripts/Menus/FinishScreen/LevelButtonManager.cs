using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtonManager : MonoBehaviour
{

    //public string leveltoload;

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //ScoringSystem.reset;
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}