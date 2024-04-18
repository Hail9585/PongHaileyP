//use player input to use player paddle

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour
{
    //public variable to control speed
    public float movespeed = 1;

    //variables to get the rigidbody component
    private Rigidbody2D RB; 

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //get player input and use to move paddle
       RB.velocity = new Vector3(0, Input.GetAxis("Vertical") * movespeed, 0);
    }
}
