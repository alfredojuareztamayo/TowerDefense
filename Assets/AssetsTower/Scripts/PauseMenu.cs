using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages the pause menu functionality.
/// </summary>
public class PauseMenu : MonoBehaviour
{
    /// <summary>
    /// The canvas for the pause menu.
    /// </summary>
    public GameObject canvasPause;

    /// <summary>
    /// The canvas for the pause button.
    /// </summary>
    public GameObject pauseButtomCanvas;

    /// <summary>
    /// Pauses the game when the pause button is pressed.
    /// </summary>
    public void PauseButtom()
    {
        pauseButtomCanvas.SetActive(false);
        Time.timeScale = 0f;
        canvasPause.SetActive(true);
    }

    /// <summary>
    /// Loads the main menu scene.
    /// </summary>
    public void Backmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    /// <summary>
    /// Resumes the game from pause.
    /// </summary>
    public void BackGame()
    {
        pauseButtomCanvas.SetActive(true);
        canvasPause.SetActive(false);
        Time.timeScale = 1f;
    }

    /// <summary>
    /// Exits the game.
    /// </summary>
    public void ExitGame()
    {
        Debug.Log("Exited the game");
        Application.Quit();
    }
}
