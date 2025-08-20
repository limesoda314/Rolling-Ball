using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI; 

public class EnemyMovement : MonoBehaviour
{

    //public variables 
    public Transform player;
    private NavMeshAgent navMeshAgent; 

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            navMeshAgent.SetDestination(player.position);
        }
    }
}
