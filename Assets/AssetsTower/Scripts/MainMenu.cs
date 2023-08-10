using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Manages the main menu functionality.
/// </summary>
public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// The GameObject containing the main menu buttons.
    /// </summary>
    public GameObject mainButtons;

    /// <summary>
    /// The GameObject containing the credits screen.
    /// </summary>
    public GameObject credits;

    /// <summary>
    /// The first part of the credits.
    /// </summary>
    public GameObject firstPartCredits;

    /// <summary>
    /// The second part of the credits.
    /// </summary>
    public GameObject secondPartCredits;

    /// <summary>
    /// Exits the game when the exit button is pressed.
    /// </summary>
    public void ExitButtom()
    {
        Debug.Log("Exited the game");
        Application.Quit();
    }

    /// <summary>
    /// Loads the main game scene when the start button is pressed.
    /// </summary>
    public void StartButtom()
    {
        SceneManager.LoadScene("MainSceneGame");
    }

    /// <summary>
    /// Displays the credits screen when the credits button is pressed.
    /// </summary>
    public void CreditsButtom()
    {
        mainButtons.SetActive(false);
        credits.SetActive(true);
    }

    /// <summary>
    /// Returns to the main menu from the credits screen.
    /// </summary>
    public void BackMenu()
    {
        credits.SetActive(false);
        mainButtons.SetActive(true);
    }

    /// <summary>
    /// Displays the second part of the credits.
    /// </summary>
    public void NextCredit()
    {
        firstPartCredits.SetActive(false);
        secondPartCredits.SetActive(true);
    }

    /// <summary>
    /// Returns to the first part of the credits.
    /// </summary>
    public void PreviousCredit()
    {
        secondPartCredits.SetActive(false);
        firstPartCredits.SetActive(true);
    }
}