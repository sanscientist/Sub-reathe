using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //used for user interface
using UnityEngine.SceneManagement; //change to a different scene/reload

public class GameOverLow : MonoBehaviour
{
    public void RestartButton()
    {
        //if(GameManger.isTop == true && GameManager.isLow == false)
        //{

        SceneManager.LoadScene("Training");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f; //resets motion

        //}
    }

    public void QuitButton()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f; //resets motion
    }
}
