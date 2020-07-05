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

    private void Awake()
    {
        //AllCollectObjects = GameObject.FindGameObjectsWithTag("_3Raumschiffteile-Turn");
    }
    void Start()
    {
        theScore = 0;

        //Array mischen dass Reihenfolge zufällig ist
        

        for (int apos = 0; apos < AllCollectObjects.Length; apos++)
        {
            CollectObject tmp = AllCollectObjects[apos];
            int r = Random.Range(apos, AllCollectObjects.Length);
            AllCollectObjects[apos] = AllCollectObjects[r];
            AllCollectObjects[r] = tmp;
        }


        //Mit for-Schleife alle überflüssigen Objekte löschen
        for (int i = 0; i < 15; i++)
        {
           // int randomIndex = Random.Range(0, AllCollectObjects.Length);
            AllCollectObjects[i].GetComponent<MeshRenderer>().enabled = false;
            AllCollectObjects[i].GetComponent<BoxCollider>().enabled = false;
        }

        

    }


    void Update ()
    {


        // scoreText.GetComponent<Text>().text = " Raumschiffteile: " + theScore + "/15";
        scoreText.text = "Raumschiffteile: " + theScore + "/15";

    }

   
        
     
}
