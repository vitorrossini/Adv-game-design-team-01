using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;
using UnityEngine.SceneManagement;



public class WinUI : MonoBehaviour
{

    private StudioEventEmitter music;
    private int currentScene;
 
    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;

        music = GameObject.Find("Music").GetComponent<FMODUnity.StudioEventEmitter>();
    }

    private void Update()
    {
        
    }

    public void Resume()
    {


        music.Stop();
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
        music.Stop();
        Time.timeScale = 1;
        SceneManager.LoadScene(currentScene + 1);
        if (currentScene +1 == null)
        {
            SceneManager.LoadScene(currentScene);
        }
    }
}
