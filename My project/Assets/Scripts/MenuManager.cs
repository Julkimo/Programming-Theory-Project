using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject helpScreen;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ShowHelp()
    {
        helpScreen.SetActive(true);
    }
    public void CloseHelp()
    {
        helpScreen.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
