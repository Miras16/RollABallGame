using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boss : MonoBehaviour
{
    public GameObject bo;
    public sphere_control sph;
     public Enemy en;
    public BossBehaviour bbb;
    public int hp=0;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
       
        // if(en.health==3)
        // {
        // Destroy(bo);
        // }
        
    }
     public void OnCollisionEnter(Collision collision)
  {
    // if (collision.gameObject.tag == "Player")
    //     {
           
    //         hp = hp + 1;
        
    //     }

    
  }
}
