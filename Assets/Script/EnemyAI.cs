using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    public List<Transform> patrolPoint;
    public PlayerControler player;
    public float viewAngle;
    public float damage = 30;

    private NavMeshAgent _navMeshAgent;
    private bool _isPlayerNoticed;
    private EnemyHealth enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
     _navMeshAgent = GetComponent<NavMeshAgent>();
     enemyHealth = GetComponent<EnemyHealth>();

     AI();   
    }
      public bool IsAlive()
      {
       return enemyHealth.IsAlive();
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
      Attack();
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
            if(_navMeshAgent.remainingDistance <=_navMeshAgent.stoppingDistance)
            {
                AI();
            }
        }
    }
     void Attack()
    {
        if(_isPlayerNoticed)
        {
            if(_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
            {
                player.GetComponent<PlayerHealth>().DealDamage(damage * Time.deltaTime);               
            }
        }
    }
     
} 
