using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;
using UnityEngine.SceneManagement;



public class WinUI : MonoBehaviour
{
    
    public FMOD.Studio.EventInstance Music;
    private int currentScene;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        Music = FMODUnity.RuntimeManager.CreateInstance("event:/Music");
    }

    private void Update()
    {
        
    }

    public void Resume()
    {
        Music.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        
        Time.timeScale = 1;
        gameObject.SetActive(false);
        SceneManager.LoadScene(currentScene);

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
