using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float damage = 10;

    private void Start()
    {
        Invoke("DestroyFireball",lifetime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        var enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if(enemyHealth != null)
        {
            enemyHealth.value -= damage;
            if(enemyHealth.value <=0)
            {
             Destroy(enemyHealth.gameObject);   
            }
        }
    
     DestroyFireball();   
    }
    // Update is called once per frame
    void Update()
    {
     transform.position += transform.forward * speed * Time.deltaTime;   
    }
    public void DestroyFireball()
    {
    Destroy(gameObject);  
    }
}
