using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granata : MonoBehaviour
{
    public Rigidbody grenadePrefab;
    public Transform grenadeSourceTransform;

    public float force = 10;
    
    // Update is called once per frame
    void Update()
    {
     if(Input.GetMouseButtonDown(1))
     {
         var grenade = Instantiate(grenadePrefab);
        grenade.transform.position = grenadeSourceTransform.position;
        grenade.GetComponent<Rigidbody>().AddForce(grenadeSourceTransform.forward * force);
     }   
    }
}
