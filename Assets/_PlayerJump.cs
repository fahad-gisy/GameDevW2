using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayerJump : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    private bool canJump = true; // can my player jump now?
    [SerializeField] private float jumpForce; // force vaule
    [SerializeField] private LayerMask groundLayer; // using LayerMask Specifies Layers to use in a Physics.Raycast and events
    [SerializeField] private Transform groundCheck; // transform to checking ground
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame                  //put it under our player 
    void Update()                         //player's pos  // created empty      //created layer named it ground
    {                                    //start point     //end point          //the Layer
       bool grounded = Physics.Linecast(transform.position,groundCheck.position,groundLayer); // creating linecast to check is our player on the ground!!
          if(grounded == true) // if the player on the ground
              canJump = true; // so he can jump
            else // otherwise NO JUMPING 
              canJump = false;  

            Jump(); // mothed doing the jumping part > rb.AddForce(vector3.up * 500)
    }

    private void Jump(){
          
      if(Input.GetKeyDown(KeyCode.Space) && canJump == true){
             canJump = false;
             rb.AddForce(Vector3.up * jumpForce);
      }   
    }
}
