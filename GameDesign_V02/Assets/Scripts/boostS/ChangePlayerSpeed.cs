using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerSpeed : MonoBehaviour
{
    //[Range(1f, 20f)]
    //public float newPlayerSpeed;
    public GameObject Spieler;
    //public ThirdPersonMovement funktion;
    

    // Start is called before the first frame update
    void Start()
    {
        // newPlayerSpeed = GameObject.FindWithTag("player").GetComponent<ThirdPersonMovement>().speed;
       //ThirdPersonMovement sn = Spieler.GetComponent<ThirdPersonMovement>().SpielerLangsam();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.tag == "Player")

        //playermotor playerMotor = other.gameObject.GetComponent<playermotor>();
        //playerMotor.ChangeAgentSpeed(newPlayerSpeed);

        
        //Debug.Log("Langsam");
        Spieler.GetComponent<ThirdPersonMovement>().SpielerLangsam();
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }

   /* private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ChangePlayerSpeed.
            //playermotor playerMotor = other.gameObject.GetComponent<playermotor>();
           // playerMotor.ResetAgentSpeed();
        }
    }*/
}
