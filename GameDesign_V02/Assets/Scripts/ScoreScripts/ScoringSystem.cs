using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{

    public GameObject scoreText;
    public static int theScore;

    public CollectObject[] AllCollectObjects;

    private void Start()
    {
        theScore = 0;
        //Array mischen dass Reihenfolge zufällig ist
        //Mit for-Schleife alle überflüssigen Objekte löschen
    }

    void Update ()
    {
        
        
        scoreText.GetComponent<Text>().text = "Raumschiffteile: " + theScore;
      

    }

}
