﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.TerrainAPI;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;

    public Transform cam;

    float speed = 15f;

    public float turnSmoothTime = 0.1f;
    float turnsmoothvelocity;

    Vector3 velocity;
    public float gravity = -9.81f;
    public Transform GroundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
       
    }
    void Update()
    {
        isGrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnsmoothvelocity, turnSmoothTime);

            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);       
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);


    }
    public void SpielerLangsam()
    {
       speed = 5f;
       Debug.Log("versuch");
       Invoke("ResetPlayerSpeed", 3);


    }

    public void ResetPlayerSpeed()
    {
        speed = 15f;
    }

    public void SpielerSchnell()
    {
        speed = 25f;
        Invoke("ResetPlayerSpeed", 3);
    }
}
