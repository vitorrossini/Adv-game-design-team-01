using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;
using UnityEngine.SceneManagement;
using STOP_MODE = FMOD.Studio.STOP_MODE;

public class WinUI : MonoBehaviour
{
   // public FMOD.Studio.EventInstance Music;
   

   

    public void Resume()
    {
       // Music.stop(STOP_MODE.IMMEDIATE);
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        gameObject.SetActive(false);

    }

   

    public void QuitButton()
    {
        Application.Quit();
    }
}
