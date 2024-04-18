//Ball class is used for ball movement so you can play the game!

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    //variables to get the rigidbody component
    private Rigidbody2D RB;

    //public variable to control speed
    public float movespeed = 1f;

    // thought about adding in a score but didnt have time
    int playerscore = 0;

    int enemyscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();

        //set starting velocity
        RB.velocity = new Vector3(movespeed, movespeed, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //handles collision between the ball and another object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check if ball is in score area and reset it
        if (collision.gameObject.CompareTag("Enemyscorearea"))
        {
            transform.position = Vector3.zero;
            RB.velocity = new Vector3(movespeed, movespeed, 0);
        }
        else if (collision.gameObject.CompareTag("Playerscorearea"))
        {
            transform.position = Vector3.zero;
            RB.velocity = new Vector3(movespeed, movespeed, 0);
        }
        
    }
}
