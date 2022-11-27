using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRotation : MonoBehaviour
{
    
    public float rotationZ;
    public float speed = 1f;
    [SerializeField] public GameObject chunkToRotate;

    private movement _movement;
    
   

    // Start is called before the first frame update
    public void Start()
    {
        _movement = GameObject.Find("Player").GetComponent<movement>();
        rotationZ = chunkToRotate.transform.rotation.z;
    }

    // Update is called once per frame
    public void Update()
    {
        
        
        
        
           TurnIt();
        
       

       
        

    }

   
   public void TurnIt()
    {
        if (Input.GetKey(KeyCode.B) && _movement.GetComponent<movement>().onTurnPlat == true)
        {
            Debug.LogError("yeah you can turn");

            rotationZ -= Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            rotationZ = Mathf.Clamp(rotationZ, -90, 90);

            transform.rotation = Quaternion.Euler(0, 0, rotationZ);

        }

    }
   





}
