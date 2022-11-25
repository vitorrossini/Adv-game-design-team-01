using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinUI : MonoBehaviour
{

    
    
    void Update()
    {
        
    }
    public void Resume()
    {

        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        gameObject.SetActive(false);

    }

   

    public void QuitButton()
    {
        Application.Quit();
    }
}
