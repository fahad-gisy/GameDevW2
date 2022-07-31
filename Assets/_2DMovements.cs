using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _2DMovements : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // getting Rigidbody attached to our player
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal")* speed , 0); // vector2 , getting input in X = A&D , Y = 0
        rb.velocity = new Vector2(movement.x,rb.velocity.y); // our rigidbody veloctiy equal new vetor2 movement on X = it's mean move on x with Horizontal input * speed , zero on Y
    }
}
