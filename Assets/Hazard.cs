using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed;
    [SerializeField] private Vector3 startPoint;
    
    [SerializeField] private Vector3 endPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector3.Lerp(startPoint,endPoint,Mathf.PingPong(Time.time * speed, 1));
    }

  
}
