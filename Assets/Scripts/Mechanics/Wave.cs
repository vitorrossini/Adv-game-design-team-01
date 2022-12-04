using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    // Simple script that instantiates an empty object with a collider and destroy itself after 1 min
  
    private float timer;

   

   
    public void Initialize(Vector3 direction) // i dont think this is being used
    {
    
     
    }

   
    private void Update()
    { 
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            Destroy(gameObject);
        }

        Physics2D.IgnoreLayerCollision(6, 7); // ignoring the collisions with the player, since they are at the same place


      

        
    }

   

    
}
