using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class Move : MonoBehaviour {
    private float speed;   
    private Rigidbody2D rb2d;      

   
    void Start()
    {
        speed = 10f;
        rb2d = GetComponent<Rigidbody2D>();
    }

   
    void FixedUpdate()
    {
 
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb2d.AddForce(movement * speed);
    }

}
