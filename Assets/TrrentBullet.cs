using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrrentBullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float bulletSpeed; //
    [SerializeField] private float bulletLifeSpan;
    private Rigidbody rb;
    private PlayerHealth playerHealthScript;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // getting bullet's rb
        rb.AddForce(transform.forward * bulletSpeed); // adding force * speed > on Z
        Invoke("Delete", bulletLifeSpan); // bullet's life time in world space
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Delete()
    {
        Destroy(gameObject); // delete the bullet after time life spend 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { // whenever bullet hit the player health--;
            playerHealthScript = collision.gameObject.GetComponent<PlayerHealth>();
            playerHealthScript.health--;
            
            Destroy(gameObject); // then destroy
        }
    }
}
