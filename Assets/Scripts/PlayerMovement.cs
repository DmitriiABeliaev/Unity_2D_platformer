using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    
    float horizontalMove = 0f;

    [SerializeField] private float runSpeed = 100f;
    private bool jump = false;
    private bool standing = false;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Player speed", Mathf.Abs(horizontalMove));

        
        //Debug.Log(Input.GetButtonDown("Jump"));
        if(Input.GetKey("w") || Input.GetKey("up") || Input.GetKey("space"))
        {
            jump = true;
            animator.SetBool("isJumping", jump);
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

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }

    public void onCrouching(bool isCrouching)
    {
        animator.SetBool("isCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, standing, jump);
        jump = false;

    }

    private void onTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger");
        if(other.gameObject.CompareTag("Gems"))
        {
            Destroy(other.gameObject);
        }
    }
}
