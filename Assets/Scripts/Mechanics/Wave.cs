using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
  
    private float timer;

   

   
    public void Initialize(Vector3 direction)
    {
    
     
    }

   
    private void Update()
    { 
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            Destroy(gameObject);
        }

        Physics2D.IgnoreLayerCollision(6, 7);


      

        
    }

   

    
}
