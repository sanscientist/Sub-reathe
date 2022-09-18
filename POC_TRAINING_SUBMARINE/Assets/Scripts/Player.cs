using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //change to a different scene/reload

public class Player : MonoBehaviour
{ //for the submarine
    private Rigidbody2D rb;
    [SerializeField] [Range(0f, 4f)] float lerpTime;
    [SerializeField] Vector3[] myPositions;
    int posIndex = 0;
    public GameObject Warning;


    int length;

    float t = 0f;
    // Start is called before the first frame update
    void Start()
    {
        length = myPositions.Length;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, myPositions[posIndex], lerpTime * Time.deltaTime);
        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if (t > 0.9f)
        {
            t = 0f;
            posIndex++;
            if (transform.position.y >= 2.6 || transform.position.y <= -2.6)
            {
                Warning.SetActive(true);

            }
            else
            {
                Warning.SetActive(false);
            }
            posIndex = (posIndex >= length) ? 0 : posIndex;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Top")
        {
            //Destroy(gameObject);
            FindObjectOfType<GameManager>().GameOverTop();
        }
        else if (other.gameObject.tag == "Bottom")
        {
            //Destroy(gameObject);
            FindObjectOfType<GameManager>().GameOverBottom();
        }
        else if(other.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().DecreaseScore();
            Destroy(other.gameObject); //removes game object
        }
        else if (other.gameObject.tag == "Reward")
        {
            FindObjectOfType<GameManager>().RewardScore();
            Destroy(other.gameObject); //removes game object
        }
    }

    


}
