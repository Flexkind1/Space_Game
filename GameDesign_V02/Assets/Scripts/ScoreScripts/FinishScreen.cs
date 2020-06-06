using System.Collections;
using System.Collections.Generic;
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
        if (ScoringSystem.theScore < 20) FinishDisplay.SetActive(false);
        if (ScoringSystem.theScore >= 20) FinishDisplay.SetActive(true);
    }
}
