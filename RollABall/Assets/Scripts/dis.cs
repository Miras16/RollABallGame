using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dis : MonoBehaviour
{
    public sphere_control sph;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(sph.count==15)
        {
       
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
       GetComponent<sphere_control>().enabled = false; 
        } 
    }
}
