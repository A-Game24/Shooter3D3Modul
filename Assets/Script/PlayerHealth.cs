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

    public GameObject uron;
    public GameObject uron1;
    public GameObject cube;

    public FireBallSourse FireBallSourse;

    void Start()
    {
     HP = maxHealth;
     uron.active = false;
     uron1.active = false;

    }

    public void DealDamage( float damage)
    {
     HP -= damage;
     Hal();
     
     if(HP <= 0)
     {
      GameOver.active = true;
      Gameplay.active = false;
      player.active = false;
      GetComponent<PlayerControler>().enabled = false;
      GetComponent<SampleScript>().enabled = false;
      GetComponentInChildren<NewBehaviourScript1>().enabled = false;
      GetComponentInChildren<FireBallSourse>().enabled = false;     
     }      
    }
    public void Hal()
    {
     healthBar.fillAmount= HP/maxHealth;
    }
    public void AddHealth(float amount)
    {
        HP +=amount;
        HP = Mathf.Clamp(HP, 0 ,maxHealth);
        Hal();
    }
    void Update()
    {
      if(HP > 50)
      {
        uron.active = false;
        uron1.active = false;
      }

      if(HP <= 50)
      {
        uron.active = true;
      }

      if(HP <= 20)
      {
        uron1.active = true;
        uron.active = false;
      }      
    }
}