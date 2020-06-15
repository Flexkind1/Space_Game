using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoringSystem : MonoBehaviour
{

    // public GameObject scoreText;
    public TextMeshProUGUI scoreText;
    public static int theScore;
   
    public CollectObject[] AllCollectObjects;


    void Start()
    {
        theScore = 0;

        //Array mischen dass Reihenfolge zufällig ist
        //Mit for-Schleife alle überflüssigen Objekte löschen#
      

       


        for (int i = 0; i < 15; i++)
        {
            int randomIndex = Random.Range(0, AllCollectObjects.Length);
            AllCollectObjects[randomIndex].GetComponent<MeshRenderer>().enabled = false;
            AllCollectObjects[randomIndex].GetComponent<BoxCollider>().enabled = false;
        }

        

    }


    void Update ()
    {


        // scoreText.GetComponent<Text>().text = " Raumschiffteile: " + theScore + "/15";
        scoreText.text = "Raumschiffteile: " + theScore + "/15";

    }

}
