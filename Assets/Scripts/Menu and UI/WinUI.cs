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

    private void Update()   // i wish i could remember the logic behind this. I think another script checks the "reload2" bool and i had to create this one to make it work on this script? 
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
        
        SceneManager.LoadScene(1);
    }
}
