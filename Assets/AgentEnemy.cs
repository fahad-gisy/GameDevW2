using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent Agent;
    [SerializeField] private Transform moveToPos;
    private bool isDeteced = false;
    private PlayerHealth _playerHealth;
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        _playerHealth = GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        float distence = Vector3.Distance(moveToPos.transform.position,transform.position);

        if (distence <= 10 && isDeteced == false)
        {
            Agent.destination = moveToPos.position;
        }
        else
        {
            Agent.destination = transform.position;
        }

    }
    
}
