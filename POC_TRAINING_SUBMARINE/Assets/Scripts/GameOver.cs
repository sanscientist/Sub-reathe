using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{//submarine - gameover
 // Start is called before the first frame update
    public void RestartButton()
    {
        //if(GameManger.isTop == true && GameManager.isLow == false)
        //{

        SceneManager.LoadScene("Training");
        Time.timeScale = 1f; //resets motion

        //}
    }

    public void QuitButton()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f; //resets motion
    }
}
