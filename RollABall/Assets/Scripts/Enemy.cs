using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public sphere_control sphere;
    MeshRenderer meshRenderer;
    public Material normalMaterial;
    public Material blinkMaterial;
    public GameObject enemy;
    public GameObject enemyhead;
    public bool invulnerable;
    public int health=0;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(health==1)
        // {
        // Destroy(enemy);
       
        // }
    }
     IEnumerator Invulabirity()
    {
        invulnerable = true;

        for (int i = 0; i < 7; i++)
        {
            if(i % 2 == 0)
            {
                meshRenderer.material = blinkMaterial;
            }
            else{
                meshRenderer.material = normalMaterial;
            }
            yield return new WaitForSeconds(0.5f);
        }
        
        meshRenderer.material = normalMaterial;
        invulnerable = false;
        
    }
    
      public void OnCollisionEnter(Collision collision)
  {
    // if (collision.gameObject.tag == "Player")
    //     {
           
    //         health = health + 1;
    //          Destroy(enemy);
        
    //     }

    
  }
 

  
  
}
