using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    private Rigidbody2D RB;

    public float movespeed = 1f;

    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
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
