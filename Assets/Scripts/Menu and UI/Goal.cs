using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using UnityEngine;
using UnityEngine.EventSystems;

public class Goal : MonoBehaviour
{
    public FMOD.Studio.EventInstance Music;
   [SerializeField] public GameObject Win;
    public GameObject againButton;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.layer == 7)
        {
            
            Time.timeScale = 0f;
            Win.SetActive(true);
            Music.stop(STOP_MODE.IMMEDIATE);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(againButton);
        }
    }
}
