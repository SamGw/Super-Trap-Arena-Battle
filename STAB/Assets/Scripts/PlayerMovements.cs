using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [Header("Properties")] 
    public float speed = 40f;
    public float jumpSpeed = 10f;
    public float maxVelocityx = 4f;

    private float moveHorizontal;
    private int jumpLeft = 2;
    private bool canJump;
    private int player;

    Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal_lr");
        canJump = Input.GetKeyDown("up");
    }

    void FixedUpdate()
    {
        Move();

        Jump();

        CapVelocity();

        Flip();
    }


    void Move()
    {
        Vector2 movement = new Vector2(moveHorizontal, 0);
        rb2d.AddForce(movement * speed);
    }
    
    void Jump()
    {
        if (jumpLeft > 0 && canJump)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
            jumpLeft--;
        }
    }

    void CapVelocity()
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

    void Flip()
    {
        if (rb2d.velocity.x > 0)
        {
            Vector3 lTemp;
            lTemp = transform.localScale;
            if (lTemp.x <= 0)
            {
                lTemp.x *= -1;
                transform.localScale = lTemp;
            }
        }

        else if (rb2d.velocity.x < 0)
        {
            Vector3 lTemp;
            lTemp = transform.localScale;
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