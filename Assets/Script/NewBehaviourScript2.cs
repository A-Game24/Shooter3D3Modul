using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript2 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey(KeyCode.R))
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      }  
    }
}
