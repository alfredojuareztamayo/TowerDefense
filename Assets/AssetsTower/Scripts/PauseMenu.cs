using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject canvasPause;
    public GameObject pauseButtomCanvas;
    public void PauseButtom()
    {
        pauseButtomCanvas.SetActive(false);
        Time.timeScale = 0f;
        canvasPause.SetActive(true);
    }
   public void Backmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void BackGame()
    {
        pauseButtomCanvas.SetActive(true);
        canvasPause.SetActive(false);
        Time.timeScale = 1f;
        
    }
    public void ExitGame()
    {
        Debug.Log("Saliste desde el juego");
        Application.Quit();
    }
}
