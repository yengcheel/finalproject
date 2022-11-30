using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public GameObject winScreenUI;
    
        
    public void _win()
    {
        winScreenUI.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void quitgame()
    {
        Application.Quit();
    }
}
