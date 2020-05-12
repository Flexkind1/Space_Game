using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Referenz um sich zu bewegen mit dem Namen controller.
    public CharacterController controller;

    // Laufgeschwindigkeit des Players.
    public float speed = 12f;

    // Geschwindigkeit deklariert.
    Vector3 velocity;
    
    // Schwerkraft deklariert. Schwerkraftwert von unserer Erde.
    public float gravity = -9.81f;

    // Unity stellt fest ob der Player auf einem Objekt steht oder nicht
    public Transform groundCheck;

    // Im Unity-Editor wurde ein GroundCheck-Objekt erstellt, eine Sphere mit einem Radius, die obige Bedingung
    // testen soll. In der folgenden Zeile wird der Radius dieser Sphere kontrolliert.
    public float groundDistance = 0.4f;

    // Test mit welchen Objekten die Sphere checken soll, also Objekt oder Spieler.
    public LayerMask groundMask;

    // Springhöhe wird deklariert.
    public float jumpHeight = 3f;

    // Variable soll checken, ob wir geerdet sind oder nicht.
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Wenn die Sphere mit festgelegtem Radius mit etwas (Objekt) kollidiert, dass in unserer groundMask festgelegt 
        // wurde, ist isGrounded wahr, wenn nicht ist isGrounded falsch.
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        // Wenn isGrounded und der y-Wert der Fallgeschwindigkeit kleiner 0 ist,
        if (isGrounded && velocity.y < 0)
        {
            // dann ist die Fallgeschwindigkeit negativ, also keine Fallgeschwindigkeit.
            velocity.y = -2f;

        }
        // Input festlegen
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // In welche Richtung man sich bewegen möchte.
        // nach rechts laufen mal x-Werte der X-Achse und vorwärts laufen mal z-Werte der Z-Achse.
        Vector3 move = transform.right * x + transform.forward * z;

        // Bewegung wird mit der Geschwindigkeit multipliziert.
        // Time.deltaTime damit die Bewegung Frame-Rate-unabhängig bleibt.
        controller.Move(move * speed * Time.deltaTime);

        // Wenn Leertaste gedrück wird und man am Boden ist (die GroundCheck Sphere, mit den in der LayerMask 
        // zugelassen Objekten kollidiert, 
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            // dann wird die Fallgeschwindigkeit durch folgende physische Formel beeinflusst.
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        
        // Geschwindigkeit der y-Achse (hoch und runter)
        // velocity.y = (velocity.y + gravity) * Time.deltaTime
        velocity.y += gravity * Time.deltaTime;

        // Geschwindigkeit auf unseren Player auswirken lassen:
        // Spieler soll sich basierend auf der Geschwindigkeit bewegen.
        // delta y = 1/2 * gravity * time hoch 2 -> deswegen Time.deltaTime, da dass die Physik eines freien Falls ist.
        controller.Move(velocity * Time.deltaTime);
    }
}
