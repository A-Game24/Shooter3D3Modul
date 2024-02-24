using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform tran;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetMouseButtonDown(0))
     {
        Instantiate(fireballPrefab,tran.position,tran.rotation);
     }   
    }
}
