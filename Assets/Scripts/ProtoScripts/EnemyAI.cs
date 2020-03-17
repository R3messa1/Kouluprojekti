using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent NavMeshAgent;
    // Start is called before the first frame update
    void Start()
    {

        NavMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {

        NavMeshAgent.SetDestination(target.position);

    }
}
