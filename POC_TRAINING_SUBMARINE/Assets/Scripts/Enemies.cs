using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed = 5f; //reference to speed
    private Rigidbody2D rb;
    public float leftEdge;

    private Vector2 screenBounds; //removes object past the screen
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        //rb.velocity = new Vector2(-speed, 0); //ensures moves from right to left
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;

    }

    // Update is called once per frame
    void Update()
    {
        //if(transform.position.x < screenBounds.x) //position x less than screen x
        //{
        //Destroy(this.gameObject);
        //}

        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
