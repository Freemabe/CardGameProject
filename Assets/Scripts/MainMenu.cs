using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
    	SceneManager.LoadScene(1);
    }

    public void OpenGarage()
    {
    	SceneManager.LoadScene(2);
    }

    public void OpenDeck()
    {
    	SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
    	Debug.Log("Quitting Game");
    	Application.Quit();
    }
}
