using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        print("...sound?");
        collectSound.PlayOneShot(collectSound.clip);
       // if (other != null) collectSound.Play();
        ScoringSystem.theScore += 1;
        //Destroy(gameObject);
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }

}
