using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrentAi : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform player; // getting the player transform
    private bool detecetd = false;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private GameObject bullet;
    void Start()
    { // finding player's pos in world space
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {//lookAt the player that equal our player's transform (aim bot)
        transform.LookAt(player);
        DetectingPlayer(); // distance math
    }

    private void DetectingPlayer()
    {//getting the distance between player , and this obj
        float playerDistance = Vector3.Distance(player.transform.position, transform.position);

        if (playerDistance <= 15 && detecetd == false)
        {
            detecetd = true;
            InvokeRepeating("Shooting",0,1);
        }
        else if(playerDistance > 15)
        {
            detecetd = false;
            CancelInvoke("Shooting");
        }
        
    }

    private void Shooting()
    {  //creating the bullet
        Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    }
}


