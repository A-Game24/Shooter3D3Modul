using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHealth : MonoBehaviour
{
   public  GameObject aidkitPrefab;
   public float delayMin = 3;
   public float delayMax = 3;
   private GameObject _aidkit;
   public List<Transform> spawnerPoints;

   public void Update()
   {
    if(_aidkit != null) return;
    {
     if(IsInvoking()) return;
     Invoke("CreateAidkit",Random.Range(delayMin,delayMax));   
    }            
   }

   private void CreateAidkit()
   {
     _aidkit = Instantiate(aidkitPrefab);
     _aidkit.transform.position = spawnerPoints[Random.Range(0,spawnerPoints.Count)].position;
   } 
}
