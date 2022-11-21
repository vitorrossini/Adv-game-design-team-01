using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRotation : MonoBehaviour
{
    public float degreesPerSecond = 30;
    public Transform pivot;
   

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
        transform.RotateAround(pivot.position, Vector3.forward, degreesPerSecond);
    }
}
