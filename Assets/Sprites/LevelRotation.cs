using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRotation : MonoBehaviour
{
    public float degreesPerSecond = 30;
   

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            RotateLevel();
        }

       
        

    }

    public void RotateLevel()
    {
        transform.Rotate(new Vector3 (0,0,degreesPerSecond) * Time.deltaTime);
    }
}
