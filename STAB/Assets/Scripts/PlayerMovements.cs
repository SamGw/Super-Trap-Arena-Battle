﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [Header("Properties")] 
    public float speed = 40f;
    public float jumpHeight = 10f;
    [Range(1,3)]
    public int player = 1;

    [Space] [Header("Hit Stun")] 
    public bool hitStun = false;
    
    private float moveHorizontal;
    private int jumpLeft = 2;
    private bool wantJump;
    private float maxVelocityx = 4f;
    
    private Animator anim;

    private string horizontalKey;
    private string jumpKey;
    private KeyCode attacKey;

    Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        Bindings();
    }

    void Update()
    {
        GetEntry();

        SelectAnimation();
    }

    void FixedUpdate()
    {
        Move();

        Jump();

        CapVelocity();

        Flip();
    }

    void Bindings()
    {
        if (player == 1)
        {
            horizontalKey = "Horizontal_ad";
            jumpKey = "w";
            attacKey = KeyCode.Q;
        }
        if (player == 2)
        {
            horizontalKey = "Horizontal_lr";
            jumpKey = "up";
            attacKey = KeyCode.M;
        }

        if (player == 3)
        {
            horizontalKey = "Horizontal_gj";
            jumpKey = "y";
            attacKey = KeyCode.O;
        }
    }

    void GetEntry()
    {
        moveHorizontal = Input.GetAxisRaw(horizontalKey);
        wantJump = Input.GetKeyDown(jumpKey);
    }

    void SelectAnimation()
    {
        if (Input.GetKeyDown(attacKey))
        {
            anim.Play("Attack");
        }

        else if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !anim.IsInTransition(0))
        {
            anim.Play("Walk");
        }
    }

    void Move()
    {
        Vector2 movement = new Vector2(moveHorizontal, 0);
        rb2d.AddForce(movement * speed);
    }
    
    void Jump()
    {
        if (jumpLeft > 0 && wantJump)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpHeight);
            jumpLeft--;
        }
    }

    void CapVelocity()
    {
        if (!hitStun)
        {
            if (rb2d.velocity.x > maxVelocityx)
            {
                rb2d.velocity = new Vector2(maxVelocityx, rb2d.velocity.y);
            }
            else if (rb2d.velocity.x < -maxVelocityx)
            {
                rb2d.velocity = new Vector2(-maxVelocityx, rb2d.velocity.y);
            }
        }
    }

    void Flip()
    {
        if (moveHorizontal > 0)
        {
            Vector3 lTemp = transform.localScale;;
            if (lTemp.x <= 0)
            {
                lTemp.x *= -1;
                transform.localScale = lTemp;
            }
        }

        else if (moveHorizontal < 0)
        {
            Vector3 lTemp = transform.localScale;;
            if (lTemp.x >= 0)
            {
                lTemp.x *= -1;
                transform.localScale = lTemp;
            }
        }
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ground")
            || other.collider.CompareTag("Side_L")
            || other.collider.CompareTag("Side_R"))
        {
            jumpLeft = 2;
        }
    }
    
}
