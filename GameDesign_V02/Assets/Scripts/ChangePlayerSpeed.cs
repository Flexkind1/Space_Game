using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerSpeed : MonoBehaviour
{
    [Range(1f, 20f)]
    public float newPlayerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playermotor playerMotor = other.gameObject.GetComponent<playermotor>();
            playerMotor.ChangeAgentSpeed(newPlayerSpeed);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playermotor playerMotor = other.gameObject.GetComponent<playermotor>();
            playerMotor.ResetAgentSpeed();
        }
    }
}
