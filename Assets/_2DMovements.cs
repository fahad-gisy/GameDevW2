using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class _2DMovements : MonoBehaviour
{
    public Transform playerRot;
    // public CharacterController characterController;
    public float speed = 5.0f;
    public float mouseSpeed;
    [SerializeField] private LayerMask groundLayer;
    public Rigidbody rb;
    private float facing;
    // private Vector3 velcoity;
    // private float gravity = -9.81f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        // characterController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    
        // if (movement.x != 0)
        {// facing float to equal the angle at which the player is moving in.
         /*Mathf.Atan2() * Mathf.Rad2Deg. What this does is it takes two values into the parenthesis and measures a value between the two, converting it into a rotational angle.*/
         // facing = Mathf.Atan2(movement.x,0) * Mathf.Rad2Deg;
        }//reference the player's Rigidbody and rotate its Y axis to stay updated with what our facing value is
        // rb.rotation = Quaternion.Euler(0,facing,0);
        
        
        // Vector2 movement = new Vector2(Input.GetAxis("Vertical")* speed , 0); // vector2 , getting input in X = A&D , Y = 0
        // rb.velocity = new Vector2(movement.x,rb.velocity.y); // our rigidbody veloctiy equal new vetor2 movement on X = it's mean move on x with Horizontal input * speed , zero on Y
        //
        // Vector3 zmovements = new Vector3(0,0,Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        // transform.position += zmovements;
        
        
        
        float mouseInput = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        playerRot.Rotate(Vector3.up * mouseInput);
        
        float inputH = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // getting A&D input >  X
        float inputV = Input.GetAxis("Vertical") * speed * Time.deltaTime; // getting W&S >  Z
        Vector3 moverotate = transform.right * inputH + transform.forward * inputV;
        rb.position += moverotate;


        // Vector3 movingForward = transform.right * inputH + transform.forward * inputV; // moving while facing and looking to the way we are moving tomo

        // characterController.Move(movingForward);

        // velcoity.y += gravity * Time.deltaTime;
        // characterController.Move(velcoity * Time.deltaTime);







    }
}
//Horizontal
//Vertical