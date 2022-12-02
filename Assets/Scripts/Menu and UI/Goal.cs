using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using UnityEngine;
using UnityEngine.EventSystems;

public class Goal : MonoBehaviour
{
   [SerializeField] public GameObject Win;
    public GameObject againButton;
    public bool win = false;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.layer == 7)
        {
            
            Time.timeScale = 0f;
            Win.SetActive(true);
            win = true;
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(againButton);
        }
        else
        {
            win = false;
        }
    }
}
