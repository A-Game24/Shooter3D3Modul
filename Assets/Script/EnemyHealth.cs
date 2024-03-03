using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int Score = 0;
    public float value = 100;
    //public Text ScoreText;

   public void DealDamage(float damage)
   {
    value -= damage;
    if(value <= 0)
    {
        Destroy(gameObject);
    }
   }
   public bool IsAlive()
   {
    return value > 0;
   }
   void Update()
   {
   if(value > 0)
    {
     //Score++;
     //ScoreText.GetComponent<Text>().text = "Score:" + Score.ToString;
    }
    }
}
