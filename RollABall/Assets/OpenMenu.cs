using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OpenMenu : MonoBehaviour
{
   public void Open(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
    }
}
