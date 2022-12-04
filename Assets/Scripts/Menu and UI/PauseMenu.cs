using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    // Pause menu script should only work in game. I still need to check how it behaves on the Main menu

    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject pauseFirstButton;
    private int currentScene;
    public bool retried;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex; // gets the index of the current level / scene.
        retried = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {

            if (gameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }

        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        Cursor.visible = false;

    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        Cursor.visible = true;
        EventSystem.current.SetSelectedGameObject(null);  // Same as in the goal script. Clears the default button to be selected so i can chose which one i want to be the first
        EventSystem.current.SetSelectedGameObject(pauseFirstButton);



    }

    public void Retry()
    {

        retried = true;
        Time.timeScale = 1;
        gameObject.SetActive(false);
        SceneManager.LoadScene(currentScene); // Reloads the same scene 

    }

    public void QuitButton()
    {
        Application.Quit();
    }

   
}
