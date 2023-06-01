using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camd : MonoBehaviour
{
       public sphere_control sph;
    public cameraController cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
             if(sph.count==16)
        {
       GetComponent<cameraController>().enabled = false; 
        }
    }
}
