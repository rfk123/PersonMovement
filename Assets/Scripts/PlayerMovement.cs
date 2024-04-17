using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 5;
    public float turnSpeed = 90;

    private float gravity = 9.82f;
    //private float jumpHeight = 2.0f;
    private Vector3 velocity;
    


    //private bool isGrounded;

    //public LayerMask groundMask; 
    //public float groundCheckDistance = 0.4f;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        characterController.Move(transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime);


        //Rigidbody wasn't working for my capsule player so I am imposing gravity here
        if (characterController.isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }
        else
        { 
            velocity.y -= gravity * Time.deltaTime;
        }


        //attempt at jumping feature:
        //went wrong because I can't get the player grounded properly

        //isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.5f);
        //if (!isGrounded)
        //{
        //    Debug.Log("Is not grounded");
        //}

        //if (Input.GetButtonDown("Jump") && characterController.isGrounded)
        //{
        //    velocity.y += Mathf.Sqrt(jumpHeight * 2f * gravity);
        //}

        //if (Input.GetButtonDown("Jump") && isGrounded)
        //{
        //    velocity.y += Mathf.Sqrt(jumpHeight * 2f * gravity);
        //}
        //velocity.y -= gravity * Time.deltaTime;

    
        characterController.Move(velocity * Time.deltaTime);
    }

}

