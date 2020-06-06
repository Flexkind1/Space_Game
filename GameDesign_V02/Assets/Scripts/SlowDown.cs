using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour
{
    public bool Getriggert;
    public GameObject Player;
    private playermotor playermotor;

    //public Component Getcomponent()

    void Awake()
    {
        playermotor = GetComponent<playermotor>();
        //    playermotor.FastTrigger();
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Triggered");
        Getriggert = true;      
        playermotor.SlowTrigger();
            //playermotor collidingPlayer = other.gameObject.GetComponent<playermotor>();
    }

    /*void OnTriggerEnter(Collider other)
    {
        Debug.Log("No Trigger");
    }
    */
}
