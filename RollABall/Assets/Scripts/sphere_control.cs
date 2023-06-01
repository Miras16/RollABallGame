using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sphere_control : MonoBehaviour
{
    Rigidbody rb; 
    public int speed=7;
    public int count=0;
    public EnemyFollow enemycode;
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject player;
    public GameObject boss;
    public BossBehaviour b;
    public GameObject bas;
   
    // Start is called before the first frame update
    void Start()
    {
      rb=GetComponent<Rigidbody>();   
 
    }

    // Update is called once per frame
    void Update()
    {
       
      
         rb.velocity = new Vector3(Input.GetAxis("Horizontal")*speed, rb.velocity.y, Input.GetAxis("Vertical")*speed);
       
        

     if(Input.GetKeyDown(KeyCode.Space) )
    { 
        Vector3 jump = new Vector3(0.0f,200.0f,0.0f);
        rb.AddForce(jump);
    } 
       
   
    }

  
     public void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Coin") )
        {
            other.gameObject.SetActive(false);
             count = count + 1;
             
             
            
            
        }
        
      
        
        
       
      if (other.gameObject.CompareTag("Border") && count < 5)
        {
            transform.position =new Vector3(-1.40f, -0.54f,0.93f);
           
    
        }
        if (other.gameObject.CompareTag("Border") && count==5 && count<10)
        {
            transform.position =new Vector3(-3.15f, -5.34f, -14.41f);
           
    
        }
         if (other.gameObject.CompareTag("Border") && count==10 && count<15)
        {
            transform.position =new Vector3(-10.35f, -10.66f,-15.03f);
            

        
      
      
    }
    // if(count==15){
    //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    // }
    }
    
 public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            transform.localScale*=0.9f;
        }
        if(collision.gameObject.tag=="bas") 
        {
            
            b.gameObject.SetActive(false);
            enemy.gameObject.SetActive(false);

        }
       
        
        
    }
   
  
}



