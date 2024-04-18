using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D RB;

    public float movespeed = 1f;

    int playerscore = 0;

    int enemyscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        RB.velocity = new Vector3(movespeed, movespeed, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
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
