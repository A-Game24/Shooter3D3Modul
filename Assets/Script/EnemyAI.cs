using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public List<Transform> patrolPoint;
    public PlayerControler player;
    public float viewAngle;

    private NavMeshAgent _navMeshAgent;
    private bool _isPlayerNoticed;

    // Start is called before the first frame update
    void Start()
    {
     _navMeshAgent = GetComponent<NavMeshAgent>();
     AI();   
    }

    // Update is called once per frame
    void Update()
    { 
      if(_navMeshAgent.remainingDistance ==0)
      {
       AI();   
      }
       Look();

      if(_isPlayerNoticed)
      {
        _navMeshAgent.destination = player.transform.position;
      }
      Fol();
    }
    void Look()
    {
     var direction = player.transform.position - transform.position;
      _isPlayerNoticed = false;
      if(Vector3.Angle(transform.forward, direction) < viewAngle)
      {
        RaycastHit hit;
        if(Physics.Raycast(transform.position + Vector3.up,direction, out hit))
        {
          if(hit.collider.gameObject == player.gameObject)
          { 
            _isPlayerNoticed = true;
          }
        }   
    }
    }
    void AI()
    {
     _navMeshAgent.destination =patrolPoint[Random.Range(0, patrolPoint.Count)].position;    
    }
     void Fol()
    {
        if(!_isPlayerNoticed)
        {
            if(_navMeshAgent.remainingDistance ==0)
            {
                AI();
            }
        }
    }
     
} 
