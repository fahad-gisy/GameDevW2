using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class lvl2DMoving : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float Speed = 5.0f;
    public Rigidbody rb;
    [SerializeField] private Transform grooundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float jumpForce;
    public AudioSource audioSource;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movementH = new Vector2(Input.GetAxis("Horizontal") * Speed, 0);
        rb.velocity = new Vector3(movementH.x, rb.velocity.y);

        bool grounded = Physics.Linecast(transform.position, grooundCheck.position, groundLayer);
        
        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
        else
        {
            grounded = false;
        }

        if (!grounded)
        {
            rb.AddForce(Physics.gravity * 1.0f , ForceMode.Acceleration);
        }
        
    }
    
    
}
