using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

   [SerializeField] public GameObject Win;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.layer == 7)
        {
            Debug.LogError("Collided");
            Time.timeScale = 0f;
            Win.SetActive(true);
        }
    }
}
