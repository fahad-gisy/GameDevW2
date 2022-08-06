using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawnPoint; //Transform to tell the obj where to spawn
    [SerializeField] private GameObject bullet;//the game obj we want to be spawned
    
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {//1-What game object we want to spawn,-2Where we want to spawn the game object,3-What rotation angle we want the game object to be at when it spawns in
            Instantiate(bullet, bulletSpawnPoint.position, transform.rotation);
        }
    }
}
