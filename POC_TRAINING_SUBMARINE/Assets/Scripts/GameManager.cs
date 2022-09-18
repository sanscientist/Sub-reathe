using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //used for user interface
using UnityEngine.SceneManagement; //change to a different scene/reload

public class GameManager : MonoBehaviour
{//submarine - gameManager

    public Text scoreText;
    public float score;
    public float scoreIncreasePerSecond;

    public GameObject GameOverHigh; //hitting Ceiling
    public GameObject GameOverLow; //hitting Ground
    public GameObject GameEncourage; //encourages users after 4 seconds

    bool decide = true;
    public float timeValue = 4;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreIncreasePerSecond = 1f;
        scoreText.text = "Score: " + (int)score;
    }

    // Update is called once per frame
    void Update()
    {
        IncreaseScore();
        decide = true;
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
            Encourage(decide);
            StartCoroutine(wait());
            timeValue = 10;
        }
    }

    public void GameOverTop()
    {
        Debug.Log("Game Over");
        GameOverHigh.SetActive(true);
        Time.timeScale = 0f; //pause the game
    }

    public void GameOverBottom()
    {
        Debug.Log("Game Over");
        GameOverLow.SetActive(true);
        Time.timeScale = 0f; //pause the game
    }

    public void IncreaseScore()
    {
        scoreText.text = "Score: " + (int)score;
        score += scoreIncreasePerSecond * Time.deltaTime;
    }

    public void DecreaseScore()
    {
        score-= 3;
        scoreText.text = "Score: " + (int)score;
    }

    public void RewardScore()
    {
        score += 5;
        scoreText.text = "Score: " + (int)score;
    }

    public void Encourage(bool decide)
    {
        GameEncourage.SetActive(decide);
    }

    public IEnumerator wait()
    {
        yield return new WaitForSeconds(5f);
        Debug.Log("Hi");
        decide = false;
        Encourage(decide);

    }
}
