using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else 
            {
                PauseGame();
            }
        }
    }
    // Update is called once per frame
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("Main Menu");
        ResumeGame();
    }
    public void restart()
    {
        SceneManager.LoadScene("Arena");
        ResumeGame();
    }
    public void quitgame()
    {
        Application.Quit();
    }
}
