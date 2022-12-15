using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public CharacterController2D controller;
    float HorizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump=false;

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = (Input.GetAxisRaw("Horizontal")*runSpeed);
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    void FixedUpdate()
    {
        controller.Move(HorizontalMove*Time.fixedDeltaTime,false,jump);
        jump = false;
    }
}
