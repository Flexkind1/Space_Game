using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class FinishScreen : MonoBehaviour
{
    public GameObject FinishDisplay;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoringSystem.theScore < 2) FinishDisplay.SetActive(false);
        if (ScoringSystem.theScore >= 2) FinishDisplay.SetActive(true);
    }
}
