using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        //Deactivates the Pause UI on start
        isPaused = false;
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)//If game is Paused then resume on esc key press
            {
                ResumeGame();
            }
            else//If game is Not Paused then Pause on esc key press
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);//Activate Pause UI
        Time.timeScale = 0f;//Pauses Time
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);//Deactivates Pause UI
        Time.timeScale = 1f;//Resumes Time
        isPaused = false;
    }

    public void QuitGame()//Quits the application
    {
        Application.Quit();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToSettings()
    {
        SceneManager.LoadScene("SettingsMenu");
    }
}
