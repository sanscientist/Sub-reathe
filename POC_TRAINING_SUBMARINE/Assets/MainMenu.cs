using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //used to manage different scenes
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{//submarine - main menu
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //loads next scene in the build
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit(); //ends application
    }
}
