using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    [SerializeField] private GameObject wavePrefab;
    [SerializeField] private Transform playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject newWave = Instantiate(wavePrefab);
            newWave.transform.position = playerPosition.position;
        }




    }

}