using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    private bool isActive;
    private float timer;

   

    // Start is called before the first frame update
    public void Initialize(Vector3 direction)
    {
        isActive = true;
     
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
