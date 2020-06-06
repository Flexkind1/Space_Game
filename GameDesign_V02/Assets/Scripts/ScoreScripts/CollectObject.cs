using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        //if (other != null) collectSound.Play();
        ScoringSystem.theScore += 1;
        Destroy(gameObject);
    }

}
