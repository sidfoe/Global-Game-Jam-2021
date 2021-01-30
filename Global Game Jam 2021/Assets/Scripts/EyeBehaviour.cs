﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EyeBehaviour : MonoBehaviour
{
    public GameObject leftEye;
    public GameObject rightEye;
    private bool isLeftEye = true;

    //The rotation of the eyes, set when switched so that you when you switch back its view is in the same place
    private Quaternion leftEyeRot;
    private Quaternion rightEyeRot = Quaternion.identity;

    [Header("Inputs")]
    public Vector2 moveInputs; // X for move left/right, Y for move forward/back
    public Vector2 lookInputs; // X for rotate left/right, Y for look up/down

    [Header("Moving")]
    public Rigidbody playerBody; // to walk, move body, not this
    public float speed = 25; // multiplier for movement
    public float turnSpeed = 100; // multiplier for turning

    [Header("Looking")]
    public Transform playerHead; // to look, rotate head or body (axis depending), not this
    public float lookAngleRangeY = 60; // 60' up, 60' down
    public float lookAngleRangeX = 60; // 60' up, 60' down
    private float camRotationYLeft = 0; // current camera up/down rotation value
    private float camRotationXLeft = 0; // current camera left/right rotation value
    private float camRotationYRight = 0; // current camera up/down rotation value
    private float camRotationXRight = 0; // current camera left/right rotation value

    private bool canLook = false;
    private int canLookCount = 0;

    public void Start()
    {
        playerHead.position = leftEye.transform.position;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInputs = context.ReadValue<Vector2>();
    }

    public void OnClickToLook(InputAction.CallbackContext context)
    {
        canLook = true;

        canLookCount++;

        if(canLookCount == 3)
        {
            canLook = false;
            canLookCount = 0;
        }
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        lookInputs = context.ReadValue<Vector2>();
    }

    public void OnEyeSwitch(InputAction.CallbackContext context)
    {
        SwitchEyes();
    }

    private void SwitchEyes()
    {
        if(isLeftEye == true) //switching to right eye
        {
            leftEyeRot = playerHead.rotation;

            playerHead.position = rightEye.transform.position;

            playerHead.rotation = rightEyeRot;

            isLeftEye = false;
        }

        else if(isLeftEye == false) //switching to left eye
        {
            rightEyeRot = playerHead.rotation;

            playerHead.position = leftEye.transform.position;

            playerHead.rotation = leftEyeRot;

            isLeftEye = true;
        }
    }

    // Keep input in Update when possible for smoother UX
    private void Update()
    {
        if (canLook == true)
        {
            // Only process if there is input
            if (lookInputs != Vector2.zero)
            {
                // Rotate body on Y axis of player character to turn left/right
                //playerBody.transform.Rotate(new Vector3(0, lookInputs.x * turnSpeed * Time.deltaTime), Space.Self);

                if (isLeftEye == true)
                {
                    // Build up rotation up/down input over time
                    camRotationYLeft += lookInputs.y * .2f;
                    camRotationXLeft += lookInputs.x * .2f;
                    // Clamp up/down rotation within logical bounds
                    camRotationYLeft = Mathf.Clamp(camRotationYLeft, -lookAngleRangeY, lookAngleRangeY);
                    //camRotationX = Mathf.Clamp(camRotationX, -lookAngleRangeX, lookAngleRangeX);
                    // Apply rotation to player
                    playerHead.localRotation = Quaternion.Euler(-camRotationYLeft, camRotationXLeft, 0);
                }

                if (isLeftEye == false)
                {
                    // Build up rotation up/down input over time
                    camRotationYRight += lookInputs.y * .2f;
                    camRotationXRight += lookInputs.x * .2f;
                    // Clamp up/down rotation within logical bounds
                    camRotationYRight = Mathf.Clamp(camRotationYRight, -lookAngleRangeY, lookAngleRangeY);
                    //camRotationX = Mathf.Clamp(camRotationX, -lookAngleRangeX, lookAngleRangeX);
                    // Apply rotation to player
                    playerHead.localRotation = Quaternion.Euler(-camRotationYRight, camRotationXRight, 0);
                }
            }
        }
    }

    // Keep physics-based things in FixedUpdate to reduce performance impact
    private void FixedUpdate()
    {
        // Only process if there is input
        if (moveInputs != Vector2.zero)
        {
            // Move around in XZ space
            //playerBody.AddRelativeForce(new Vector3(moveInputs.x * speed * Time.deltaTime, 0, moveInputs.y * speed * Time.deltaTime), ForceMode.Impulse);
            playerBody.transform.position += new Vector3(moveInputs.x * speed * Time.deltaTime, 0, moveInputs.y * speed * Time.deltaTime);
        }
    }
}