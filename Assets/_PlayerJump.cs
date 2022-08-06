using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayerJump : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    private bool canJump = true; // can my player jump now?
    [SerializeField] private float jumpH; // force vaule
    [SerializeField] private LayerMask groundLayer; // using LayerMask Specifies Layers to use in a Physics.Raycast and events
    [SerializeField] private Transform groundCheck; // transform to checking ground
    // public CharacterController characterController;
    // private float gravity = -9.81f;
    // private Vector3 velocity;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame                  //put it under our player 
    void Update()                         //player's pos  // created empty      //created layer named it ground
    {                                    //start point     //end point          //the Layer
       bool grounded = Physics.Linecast(transform.position,groundCheck.position,groundLayer); // creating linecast to check is our player on the ground!!
       if (grounded == true)
       { // if the player on the ground
           canJump = true; // so he can jump
       } else // otherwise NO JUMPING 
           canJump = false;
       
       //for jumping gravity you add this code to your FixedUpdate function
       if (!grounded)
       {
           // rb.AddForce(Physics.gravity * 1.0f, ForceMode.Acceleration); // the bigger the number you multiply it with, the faster it will fall 
          
       }
       Jump(); // mothed doing the jumping part > rb.AddForce(vector3.up * 500)
    }

    private void Jump(){
          
      if(Input.GetKeyDown(KeyCode.Space) && canJump == true){
             canJump = false;
             rb.AddForce(Vector3.up * jumpH);
             
             // velocity.y = Mathf.Sqrt(jumpH * -2f * gravity); //jumping logic in math
             // characterController.Move(velocity * Time.deltaTime);
      }   
    }
}
