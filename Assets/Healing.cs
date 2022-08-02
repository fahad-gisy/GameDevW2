using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerHealth playerHealthScript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            playerHealthScript = other.gameObject.GetComponent<PlayerHealth>();
            playerHealthScript.health++;
            Destroy(gameObject);
        }
    }
}
