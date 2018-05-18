using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private CharacterController controller;
    private float verticalVelocity;
    public float gravity = 1.0f;
    public float jumpForce = 12.0f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
        controller.Move(moveVector * Time.deltaTime);
    }
}
