﻿using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;

public class FinishScreen : MonoBehaviour
{
    public GameObject FinishDisplay;
    public GameObject Player;
    public AudioSource Hover;
    
   
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoringSystem.theScore < 15)FinishDisplay.SetActive(false);


        if (ScoringSystem.theScore >= 15)
        {
            FinishDisplay.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            


        }
    }

    public void OnMouseEnter()
    {
        Hover.Play();
    }
}
