using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int health; // player's health
    [SerializeField] private Transform spawnPoint; // where our player will spawned after death
    private Rigidbody rb;
    private _2DMovements moveScript; //getting player's moving script
    private _PlayerJump jumpScript; // getting player's jumping script
    private Transform enemey;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveScript = GetComponent<_2DMovements>(); // getting to component >> evade null excp >> setting the value of those vars
        jumpScript = GetComponent<_PlayerJump>();
    }

    // Update is called once per frame
    void Update()
    { // if heath <= zero then will player shall die
        if (health <= 0)
            Die();


    }

    private void Die()
    {//after death our player's pos will be equal to spawnPont's pos
        transform.position = spawnPoint.position;
        health = 3; // refill the health
    }

    private void Damage()
    {
        //whenever our enemy collde our player disable player's scirpt
        moveScript.enabled = false;
        jumpScript.enabled = false;
        
        //This will knock the player upward when colliding with the enemy.    
        rb.AddForce(Vector3.up * 250);
        // if our player x pos less than enemy x pos    
        if (transform.position.x < enemey.position.x)
            rb.AddForce(Vector3.right * -500);
/* If the player is left of the enemy when colliding, shove the player to the left by 500.
Otherwise, shove the player to the right by 500. */        
        else 
            rb.AddForce(Vector3.right * 500);
        
        Invoke("MoveAgain",1); // do it one time then player can move again
        //MIke > remember Using Coroutine is batter for game memory? don't use Invoke 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {// everytime an enemy ran into our player > health - 1;
            health--;
            enemey = collision.gameObject.transform;
            Damage();
        }
    }
    
    private void MoveAgain()
    {  // now player back to normal > stunned?
        moveScript.enabled = true;
        jumpScript.enabled = true;

    }
}
