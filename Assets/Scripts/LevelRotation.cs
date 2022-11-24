using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRotation : MonoBehaviour
{
    
    public float rotationZ;
    public float speed = 1f;
    
   

    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
        
        
        
           TurnIt();
        
       

       
        

    }

   
   public void TurnIt()
    {
        if (Input.GetKey(KeyCode.B))
        {
            Debug.LogError("yeah you can turn");

            rotationZ -= Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            rotationZ = Mathf.Clamp(rotationZ, -90, 90);

            transform.rotation = Quaternion.Euler(0, 0, rotationZ);

        }

    }
   





}
