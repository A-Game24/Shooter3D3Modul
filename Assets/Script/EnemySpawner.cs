using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   public EnemyAI enemyPrefab;
   public PlayerControler player;
   public List<Transform> spawnerPoint;
   private List<EnemyAI> enemies;
   public int  enemiesMax = 5;
   public float delay = 5;
   private float timeLastSpawner;
   public List<Transform> patrolPoint;


   void Start()
   {
    spawnerPoint = new List<Transform>(transform.GetComponentsInChildren<Transform>());
    enemies = new List<EnemyAI>();
   }

   void Update()
   {
    for(var i=0; i<enemies.Count; i++ )
    {
     if(enemies[i].IsAlive()) continue;
     enemies.RemoveAt(i); 
    }

    if(enemies.Count >= enemiesMax) return;    
    if(Time.time - timeLastSpawner < delay)return;
      
    CreateEnemy();       
           
   }

   private void CreateEnemy()
   {
    var enemy = Instantiate(enemyPrefab);
    enemy.transform.position = spawnerPoint[Random.Range(0,spawnerPoint.Count)].position;
    enemy.player = player;
    enemy.patrolPoint = patrolPoint;
    enemies.Add(enemy);    
    timeLastSpawner = Time.time;
   }
}
