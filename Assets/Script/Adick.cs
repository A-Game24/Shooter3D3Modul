using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adick : MonoBehaviour
{
    public float healAmount = 50;

     void OnTriggerEnter(Collider other)
    {               
            var playerHealth = other.gameObject.GetComponent<PlayerHealth>();
            if(playerHealth != null)
            {
                playerHealth.AddHealth(healAmount);
                Destroy(gameObject);
            }       
    }    
}
