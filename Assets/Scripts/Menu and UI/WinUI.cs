using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;
using UnityEngine.SceneManagement;



public class WinUI : MonoBehaviour
{

    
    private int currentScene;
    public bool reload = false;
    public bool reload2 = false;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        reload = false;
       
    }

    private void Update()
    {
        if(reload)
        {
            Debug.LogWarning("reload on WinUI");
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
        if (currentScene +1 == null)
        {
            SceneManager.LoadScene(currentScene);
        }
    }
}
