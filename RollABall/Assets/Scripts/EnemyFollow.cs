using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform target;
    public float speed=4f;
    Rigidbody rb;
    public sphere_control sphere;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         
        Vector3 pos=Vector3.MoveTowards(transform.position, target.position,speed*Time.fixedDeltaTime);
        rb.MovePosition(pos);
        
      
      
       
       
        
    }
   
     
    
  
   
    
    
}
