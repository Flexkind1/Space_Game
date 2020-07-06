using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.TerrainAPI;
using UnityEngine.AI;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;

    public Transform cam;

    Animator animator;

    float speed = 15f;
    float CurrentSpeed = 15f;
    float wantedSpeed;

    // float lerpTime = 1f;
    // float currentLerpTime;
    float LerpTime;

    public float turnSmoothTime = 0.1f;
    float turnsmoothvelocity;

    Vector3 velocity;
    public float gravity = -9.81f;
    public Transform GroundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    float i = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        animator = GetComponentInChildren<Animator>();
        LerpTime = 0f; 
       
    }
    void Update()
    {

        //increment timer once per frame
        /* currentLerpTime += Time.deltaTime;
         if (currentLerpTime > lerpTime)
         {
             currentLerpTime = lerpTime;
         }*/

        //lerp!

        LerpTime += Time.deltaTime;
        if(LerpTime > 1)
        {
            LerpTime = 0;
        }
        //Debug.Log(LerpTime);
        Debug.Log("speed:" + speed);


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
        animator.SetFloat("Speed", speed * direction.magnitude);
        velocity.y += gravity * Time.deltaTime;

       /* if(horizontal == 0 && vertical == 0)
        {
            speed = 0;
        }*/
      

        controller.Move(velocity * Time.deltaTime);

        
    }

    public void SpielerLangsam()
    {

        
        wantedSpeed = 5f;
        StopAllCoroutines();
        StartCoroutine("LerpTest");
        

    }

  

    public void SpielerSchnell()
    {
        wantedSpeed = 25f;
        StopAllCoroutines();
        StartCoroutine("LerpTest");
       }

 IEnumerator LerpTest()
    {
        for (int t = 0; t < 9; t++)
        {
            i += 0.1f;
            speed = Mathf.Lerp(CurrentSpeed, wantedSpeed, i);
            yield return new WaitForSeconds(0.05f);
        }
        CurrentSpeed = wantedSpeed;
        i = 0f;
        StartCoroutine("LerpReturn");
    }
    IEnumerator LerpReturn()
    {
        yield return new WaitForSeconds(3f);
        StopCoroutine("LerpTest");

        wantedSpeed = 15f;

        for (int m = 0; m < 9; m++)
        {
            i += 0.1f;
            speed = Mathf.Lerp(CurrentSpeed, wantedSpeed, i);
            yield return new WaitForSeconds(0.05f);
        }
        i = 0;
        CurrentSpeed = wantedSpeed;
        yield break;
    }
}
