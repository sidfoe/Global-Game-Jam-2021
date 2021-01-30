using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EyeBehaviour : MonoBehaviour
{
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
    private float camRotationY = 0; // current camera up/down rotation value
    private float camRotationX = 0; // current camera up/down rotation value

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInputs = context.ReadValue<Vector2>();
    }

    public void UpdateLookInputs(InputAction.CallbackContext context)
    {
        lookInputs = context.ReadValue<Vector2>();
    }

    // Keep input in Update when possible for smoother UX
    private void Update()
    {
        // Only process if there is input
        if (lookInputs != Vector2.zero)
        {
            // Rotate body on Y axis of player character to turn left/right
            //playerBody.transform.Rotate(new Vector3(0, lookInputs.x * turnSpeed * Time.deltaTime), Space.Self);

            // Build up rotation up/down input over time
            camRotationY += lookInputs.y * .2f;
            camRotationX += lookInputs.x * .2f;
            // Clamp up/down rotation within logical bounds
            camRotationY = Mathf.Clamp(camRotationY, -lookAngleRangeY, lookAngleRangeY);
            //camRotationX = Mathf.Clamp(camRotationX, -lookAngleRangeX, lookAngleRangeX);
            // Apply rotation to player
            playerHead.localRotation = Quaternion.Euler(-camRotationY, camRotationX, 0);

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
