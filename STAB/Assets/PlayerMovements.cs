﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour {
   
    [Header("Colliders")]
    public BoxCollider2D ground;
    public BoxCollider2D sideL;
    public BoxCollider2D sideR;

    [Space]

    [Header("Properties")]
    public float speed = 100f;

    private float moveHorizontal;
    private float moveVertical;
    private int jumpLeft = 2;
    private bool canJump = false;

    Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () 
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
        canJump = Input.GetKeyDown("up");
        
	}

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(moveHorizontal, 0);
        rb2d.AddForce(movement * speed);
        if (moveVertical > 0 && jumpLeft > 0 && canJump)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, speed / 4);
            jumpLeft--;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collide");
        if (collision.collider.Equals(ground) 
            || collision.collider.Equals(sideL) 
            || collision.collider.Equals(sideR))
        {
            jumpLeft = 2;
            Debug.Log("Ground");
        }
    }
}