using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour
{
    public GameObject ui;
    public GameObject objToTP; // Teleport Object
    public Transform tpLoc; // Teleport Location

    public playermotor motor;

    void Start()
    {
        ui.SetActive(false); //wir wollen den Hinweis nicht die ganze Zeit lesen, nur wnen man im Trigger Bereich steht
    }
    void OnTriggerStay(Collider other)
    {
        ui.SetActive(true);

        if((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.T)) // Taste T drücken, zum Teleportieren
        {
            objToTP.transform.position = tpLoc.transform.position; //Player wird von A nach B teleportiert

            motor.MovetoPoint(tpLoc.transform.position);
        }
    }
    void OnTriggerExit()
    {
        ui.SetActive(false);
    }
}
