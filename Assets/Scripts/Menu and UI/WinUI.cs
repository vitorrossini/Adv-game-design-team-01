using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;
using UnityEngine.SceneManagement;



public class WinUI : MonoBehaviour
{
    // Win script to let the player decide what to do next
    
    private int currentScene;
    public bool reload = false;
    public bool reload2 = false;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex; // gets current scene / level
        reload = false;
       
    }

    private void Update()   // i wish i could remeber the logic behind this. I think another script checks the "reload2" bool and i had to create this one to make it work on this script? 
    {
        if(reload)
        {
            reload2 = true;
        }
        else
        {
            reload2 = false;
        }
        
    }

      

    public void QuitButton()
    {
        Application.Quit();
    }

    public void Reload()
    {
        
        Time.timeScale = 1;
        SceneManager.LoadScene(currentScene + 1);
        if (currentScene +1 == null)  // tried to make it reload the last scene over and over again but failed. Can work on that later one either figuring out how to make it or just making an end UI
        {
            SceneManager.LoadScene(currentScene);
        }
    }
}
