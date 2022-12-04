using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using UnityEngine;
using UnityEngine.EventSystems;

public class Goal : MonoBehaviour
{

    // Simple win condition script to activate when the guitar instance collides with the goal object

   [SerializeField] public GameObject Win;
    public GameObject againButton;
    public bool win = false;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.layer == 7) // only if collides with any game object on that layer, so it can only be one for each level.
        {
            
            Time.timeScale = 0f;
            Win.SetActive(true); // Activates the Win UI
            win = true;
            EventSystem.current.SetSelectedGameObject(null); //clean the default button selection
            EventSystem.current.SetSelectedGameObject(againButton); // place the button of my choice to be the first selected
        }
        else
        {
            win = false;
        }
    }
}
