using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    
    float horizontalMove = 0f;

    [SerializeField] private float runSpeed = 100f;
    private bool jump = false;
    private bool standing = false;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        //Debug.Log(Input.GetKey("down") || Input.GetKey("s"));
        
        if(Input.GetKey("down") || Input.GetKey("s"))
        {
            standing = true;
        }
        else
        {
            standing = false;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, standing, jump);
        jump = false;

    }
}
