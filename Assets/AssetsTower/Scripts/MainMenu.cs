using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

   public GameObject mainButtons;
   public GameObject credits;
   public GameObject firstPartCredits;
   public GameObject secondPartCredits;
   
    public void ExitButtom()
    {
        Debug.Log("Saliste del juego gg");
        Application.Quit();
    }

    public void StartButtom()
    {
        SceneManager.LoadScene("MainSceneGame");
    }

    public void CreditsButtom()
    {
        mainButtons.SetActive(false);
        credits.SetActive(true);
    }

    public void BackMenu()
    {
        credits.SetActive(false);
        mainButtons.SetActive(true);
        
    }
    public void NextCredit()
    {
        firstPartCredits.SetActive(false);
        secondPartCredits.SetActive(true);
    }
    public void PreviousCredit()
    {
        secondPartCredits.SetActive(false);
        firstPartCredits.SetActive(true);
    }
}
