using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotting : MonoBehaviour
{
    //give our bullet speed
    [SerializeField] private float bulletSpeed; 
    private Rigidbody rb; //also rigidbody so it can enter act with phy 
    [SerializeField] private float bulletLifeSpan;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed); // move on X * speed
        Invoke("DeleteBullet",bulletLifeSpan); // after life span the bullet get destroyed
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {// if the bullet hit the enemy, Destroy the enemy
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void DeleteBullet()
    {
        Destroy(gameObject);//bullet Destroyer
    }
}
