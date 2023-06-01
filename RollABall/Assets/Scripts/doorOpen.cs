using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
    public bool doorIsOpen;
    public sphere_control sphere;
    public GameObject door1;
    public GameObject door2;
   

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    { 
        Debug.Log(door2.transform.position);
        if(doorIsOpen==false && sphere.count==5)
    {
        door1.transform.position = new Vector3(3.05f, 7.00f,-8.50f);
        
        
    }
    if(doorIsOpen==false && sphere.count==10)
    {
         door2.transform.position = new Vector3(-6.21f, 0.0f,-13.13f);
        // floor1.gameObject.SetActive(false); 
        
        
    }
    
    }
    public void OnCollisionEnter(Collision collision)
  {
    if(collision.gameObject.tag == "Floor"){
        doorIsOpen = false;
    }
  }
     
}
