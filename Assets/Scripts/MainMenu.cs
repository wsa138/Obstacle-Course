using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Play Game!");

    }

    public void QuitGame()
    {
        Debug.Log("Quit Game!");
        Application.Quit();
    }


}
