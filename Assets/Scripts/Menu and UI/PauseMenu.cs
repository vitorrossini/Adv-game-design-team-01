using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject pauseFirstButton;
    private int currentScene;
    public bool retried;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
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
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(pauseFirstButton);



    }

    public void Retry()
    {

        retried = true;
        Time.timeScale = 1;
        gameObject.SetActive(false);
        SceneManager.LoadScene(currentScene);

    }

    public void QuitButton()
    {
        Application.Quit();
    }

   
}
