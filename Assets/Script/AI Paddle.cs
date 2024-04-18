//Scprit controls AI Paddle

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    //variables to get the rigidbody component
    private Rigidbody2D RB;

    //public variable to control speed
    public float movespeed = 1f;

    //store ball object so paddle knows what to follow 
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //move paddle to follow ball 
        if (ball.transform.position.y < transform.position.y)
        {
            RB.velocity = new Vector3(0,-movespeed,0);
        }
        else if (ball.transform.position.y > transform.position.y)
        {
            RB.velocity = new Vector3(0, movespeed, 0);
        }
        else
        {
            RB.velocity = new Vector3(0, 0, 0);
        }
    }
}
