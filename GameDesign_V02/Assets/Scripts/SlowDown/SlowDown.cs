using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour
{
   // public bool Getriggert;
    public GameObject Player;
    private playermotor playermotor;
    public float SpielerSpeed;
    //public Component Getcomponent()

    void Awake()
    {
        playermotor = GetComponent<playermotor>();
        //    playermotor.FastTrigger();

       // playermotor.agent.speed = SpielerSpeed;
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Triggered");
        //  Getriggert = true;
        //  SpielerSpeed = 3f;
        // playermotor.SlowTrigger();
        //playermotor collidingPlayer = other.gameObject.GetComponent<playermotor>();

       // playermotor.agent.speed = 2f;

       
    }

    /*void OnTriggerExit(Collider other)
    {
        Debug.Log("No Trigger");
        playermotor
    }*/
    
}
