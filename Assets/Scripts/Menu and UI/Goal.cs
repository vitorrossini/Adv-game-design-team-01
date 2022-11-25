using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

   [SerializeField] public GameObject Win;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("wave"))
        {
            Time.timeScale = 0f;
            Win.SetActive(true);
        }
    }
}
