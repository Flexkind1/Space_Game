using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Maus-Geschwindigkeit
    public float mouseSensitivity = 500f;
    // Referenz um sich um den Player zu drehen
    public Transform playerBody;
    // wir rotieren um die x-Achse, nach oben und unten für y
    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // Fixiert den Cursor im Zentrum des Bildschirms
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // X-Achse und Y-Achse wird durch die vorprogrammierte Funktion von Unity (Mouse X/Mouse Y) ausgelesen.
        // Time.deltaTime ist die Zeit zwischen dem jetzigen und dem letzten Frame.
        // Zeile bedeutet: Wenn unsere Frame-Rate hoch ist, dann wird nicht schneller mit der Maus rotiert
        // als wenn unsere Frame-Rate niedrig ist.
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // xRotation = xRotation - mouseY
        // Die X-Rotation wird verringert, basierend auf mouseY
        xRotation -= mouseY;

        // Bereich indem der Player rotieren kann, also von oben nach unten, sodass er nicht überrotieren kann.
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Nach oben und unten rotieren wird angewendet.
        // Quaternion repräsentiert die Rotation.
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Maus rotiert um den Player; statt Vector3.up könne man auch schreiben: Vector3(0,1,0)
        // Player kann nach links und rechts schauen.
        playerBody.Rotate(Vector3.up * mouseX);

    }
}
