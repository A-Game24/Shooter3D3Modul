using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float HP = 100;
    public Image healthBar;
    public float maxHealth =100f;
    public GameObject Gameplay;
    public GameObject GameOver;
    public GameObject player;

    void Start()
    {
     HP = maxHealth;
    }

    public void DealDamage( float damage)
    {
     HP -= damage;
     healthBar.fillAmount= HP/maxHealth;
     if(HP <= 0)
     {
      GameOver.active = true;
      Gameplay.active = false;
      player.active = false;
      GetComponent<PlayerControler>().enabled = false;
      GetComponent<SampleScript>().enabled = false;
      GetComponent<FireBallSourse>().enabled = false;
      GetComponent<NewBehaviourScript1>().enabled = false;
      GetComponent<FireBallSourse>().enabled = false;
      
     }   
    }

 
}
