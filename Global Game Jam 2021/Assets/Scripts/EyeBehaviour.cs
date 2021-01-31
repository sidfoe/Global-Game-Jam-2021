using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class EyeBehaviour : MonoBehaviour
{
    public GameObject leftEye;
    public GameObject rightEye;
    private bool isLeftEye = true;

    public GameObject leftUI;
    public GameObject rightUI;

    private bool leftEyeAttached = false;
    private bool rightEyeAttached = false;

    //The rotation of the eyes, set when switched so that you when you switch back its view is in the same place
    private Quaternion leftEyeRot;
    private Quaternion rightEyeRot = Quaternion.identity;

    [Header("Inputs")]
    public Vector2 moveInputs; // X for move left/right, Y for move forward/back
    public Vector2 lookInputs; // X for rotate left/right, Y for look up/down

    [Header("Moving")]
    public Rigidbody playerBody; // to walk, move body, not this
    public float speed = 25; // multiplier for movement
    public float rotateSpeed = 100; // multiplier for turning
    public float jumpHeight;

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

    private bool canRotate = false;
    private int canRotateCount = 0;
    private bool rotateLeft = true;

    public InputActionReference movement;
    public InputActionReference jump;
    private bool groundedPlayer;
    private Vector3 playerVelocity;
    public float gravity;

    private bool hasPickedUp = false;

    public static bool hasBothEyes = false;
    public GameObject endPanel;

    public void Start()
    {
        playerHead.position = leftEye.transform.position;
        playerHead.SetParent(leftEye.transform);

        rightUI.SetActive(false);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInputs = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
  
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

    public void OnRotateLeft(InputAction.CallbackContext context)
    {
        rotateLeft = true;
        canRotate = true;

        canRotateCount++;

        if (canRotateCount == 3)
        {
            canRotate = false;
            canRotateCount = 0;
        }
    }

    public void OnRotateRight(InputAction.CallbackContext context)
    {
        rotateLeft = false;
        canRotate = true;

        canRotateCount++;

        if (canRotateCount == 3)
        {
            canRotate = false;
            canRotateCount = 0;
        }
    }

    public void OnGrab(InputAction.CallbackContext context)
    {
        if (hasPickedUp == true)
        {
            Debug.Log("here");
            hasPickedUp = false;
            playerBody.GetComponent<CollisionCheck>().colObject.GetComponent<Rigidbody>().isKinematic = false;
            playerBody.GetComponent<CollisionCheck>().colObject.transform.SetParent(null);
        }

        else if (playerBody.GetComponent<CollisionCheck>().nearPickUp == true)
        {
            if(playerBody.GetComponent<CollisionCheck>().itemTag == "Eye")
            {
                if(playerBody.GetComponent<CollisionCheck>().colObject == leftEye)
                {
                    leftEye.transform.position = playerBody.transform.GetChild(1).gameObject.transform.position;
                    leftEye.transform.SetParent(playerBody.transform.GetChild(1).gameObject.transform);
                    leftEyeAttached = true;
                    leftEye.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    playerHead.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    leftEyeRot = playerHead.transform.rotation;
                    leftEye.tag = "Untagged";
                }

                else
                {
                    rightEye.transform.position = playerBody.transform.GetChild(0).gameObject.transform.position;
                    rightEye.transform.SetParent(playerBody.transform.GetChild(0).gameObject.transform);
                    rightEyeAttached = true;
                    rightEye.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    playerHead.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    rightEyeRot = playerHead.transform.rotation;
                    rightEye.tag = "Untagged";
                }
            }

            if(playerBody.GetComponent<CollisionCheck>().itemTag == "PickUp" && hasPickedUp == false)
            {
                hasPickedUp = true;
                playerBody.GetComponent<CollisionCheck>().colObject.GetComponent<Rigidbody>().isKinematic = true;
                playerBody.GetComponent<CollisionCheck>().colObject.transform.SetParent(playerBody.transform.GetChild(2).gameObject.transform);
                playerBody.GetComponent<CollisionCheck>().colObject.transform.localPosition = Vector3.zero;
            }
        }

        
    }

    public void OnBackToMain(InputAction.CallbackContext context)
    {
        SceneManager.LoadScene(0);
    }

    public void OnRestart(InputAction.CallbackContext context)
    {
        int i = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(i);
    }

    private void SwitchEyes()
    {
        if(isLeftEye == true) //switching to right eye
        {
            leftEyeRot = playerHead.rotation;

            playerHead.position = rightEye.transform.position;
            playerHead.SetParent(rightEye.transform);
            playerHead.transform.localPosition = new Vector3(0, 0, 0);
            

            playerHead.rotation = rightEyeRot;

            isLeftEye = false;

            rightUI.SetActive(true);
            leftUI.SetActive(false);
        }

        else if(isLeftEye == false) //switching to left eye
        {
            rightEyeRot = playerHead.rotation;

            playerHead.position = leftEye.transform.position;
            playerHead.SetParent(leftEye.transform);
            playerHead.transform.localPosition = new Vector3(0, 0, 0);
           

            playerHead.rotation = leftEyeRot;

            isLeftEye = true;

            rightUI.SetActive(false);
            leftUI.SetActive(true);
        }
    }

    // Keep input in Update when possible for smoother UX
    private void Update()
    {
        if(leftEyeAttached == true && rightEyeAttached == true)
        {
            hasBothEyes = true;
            StartCoroutine("Ending");
        }

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
                    if (leftEyeAttached == false)
                    {
                        camRotationXLeft += lookInputs.x * .2f;
                    }
                    else
                    {
                        camRotationXLeft = 0;
                    }
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
                    if (rightEyeAttached == false)
                    {
                        camRotationXRight += lookInputs.x * .2f;
                    }
                    else
                    {
                        camRotationXRight = 0;
                    }
                    // Clamp up/down rotation within logical bounds
                    camRotationYRight = Mathf.Clamp(camRotationYRight, -lookAngleRangeY, lookAngleRangeY);
                    //camRotationX = Mathf.Clamp(camRotationX, -lookAngleRangeX, lookAngleRangeX);
                    // Apply rotation to player
                    playerHead.localRotation = Quaternion.Euler(-camRotationYRight, camRotationXRight, 0);
                }
            }
        }

        if(canRotate == true)
        {
            if(rotateLeft == true)
            {
                playerBody.transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
            }

            if(rotateLeft == false)
            {
                playerBody.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
            }
        }

        groundedPlayer = playerBody.GetComponent<CharacterController>().isGrounded;
        if(groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }


        //MOVEMENT
        Vector2 moveControl = movement.action.ReadValue<Vector2>();
        Vector3 move = new Vector3(moveControl.x, 0, moveControl.y);
        move = playerBody.transform.forward * move.z + playerBody.transform.right * move.x;
        move.y = 0;

        playerBody.GetComponent<CharacterController>().Move(move * Time.deltaTime * speed);

        if(jump.action.triggered && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3 * gravity);
        }

        playerVelocity.y += gravity * Time.deltaTime;
        playerBody.GetComponent<CharacterController>().Move(playerVelocity * Time.deltaTime);
    }

    // Keep physics-based things in FixedUpdate to reduce performance impact
    private void FixedUpdate()
    {

        // Only process if there is input
        //if (moveInputs != Vector2.zero)
        //{
        // Move around in XZ space
        //playerBody.AddRelativeForce(new Vector3(moveInputs.x * speed * Time.deltaTime, 0, moveInputs.y * speed * Time.deltaTime), ForceMode.Impulse);



        //playerBody.transform.position += new Vector3(move.x * speed * Time.deltaTime, 0, move.y * speed * Time.deltaTime);

        //playerBody.transform.position += new Vector3(moveInputs.x * speed * Time.deltaTime, 0, moveInputs.y * speed * Time.deltaTime);
        //}
    }

    public IEnumerator Ending()
    {
        endPanel.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }
}
