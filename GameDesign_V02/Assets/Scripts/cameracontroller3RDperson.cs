using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller3RDperson : MonoBehaviour
{
    public Transform target;
     

    public Vector3 offset;
    public float zoomSpeed = 4f;
    public float minZoom = 5f;
    public float maxZoom = 15f;

    public float yawSpeed = 100f;

    public float pitch = 0.01f;

    private float currentZoom = 10f;
    private float yawInput = 0f;

  
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

        yawInput += Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;
        //yawInput += Input.GetAxis("vertical") * yawSpeed * Time.deltaTime;

    }

    private void LateUpdate()
    {
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + Vector3.up * pitch);

        transform.RotateAround(target.position, Vector3.up, yawInput);
        //transform.RotateAround(target.position, Vector3.left, yawInput);
        //transform.RotateAround(target.position, Vector3.right, yawInput);

        /*
        float xAxisValue = Input.GetAxis("Horizontal") * Speed;
        float zAxisValue = Input.GetAxis("Vertical") * Speed;

        transform.rotation = new Vector3(transform.rotation.x + xAxisValue, transform.rotation.y, transform.rotation.z + zAxisValue);
        */
    }
}
