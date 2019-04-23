using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using Random = System.Random;

public class IA : MonoBehaviour
{
    [Header("Properties")] 
    public float speed = 40f;
    public float jumpHeight = 10f;

    [Space] [Header("Hit Stun")] 
    public bool hitStun = false;
    
    private float moveHorizontal;
    private int jumpLeft = 2;
    private bool wantJump;
    private float maxVelocityx = 4f;
    private int move = 0;
    private bool left = true;
    private bool attack = false;
    private float goTox = 0;
    private float goToy = 0;
    
    private Animator anim;
    private Random r;

    private string horizontalKey;
    private string jumpKey;
    private KeyCode attacKey;

    Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        r = new Random();
    }

    void Update()
    {
        SelectAnimation(false);
    }

    void FixedUpdate()
    {
        
        Brain();

        CapVelocity();

        Flip();
    }

    void Brain()
    {
        if (GameObject.Find("Perso cubique").transform.position.x < -9 ||
            GameObject.Find("Perso cubique").transform.position.x > 7)
        {
            goTox = 0;
            goToy = 0;
        }
        else
        {
            goTox = GameObject.Find("Perso cubique").transform.position.x;
            goToy = GameObject.Find("Perso cubique").transform.position.y;
        }


        if (rb2d.position.x > goTox - 0.3)
        {
            left = true;
            move = -1;
            Move(move);
        }
        else if (rb2d.position.x < goTox + 0.3)
        {
            left = false;
            move = 1;
            Move(move);
        }
        else
        {
            if (r.Next(2) == 1)
                Jump(true);
            else
                Jump(!false);
        }


        if (rb2d.position.y < goToy)
        {
            Jump(left);
        }
        
        if (Math.Abs(rb2d.position.x - GameObject.Find("Perso cubique").transform.position.x) <= 1)
        {
            attack = true;
            SelectAnimation(attack);
        }
    }

    void SelectAnimation(bool attack)
    {
        if (attack)
        {
            anim.Play("Attack");
        }

        else if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !anim.IsInTransition(0))
        {
            anim.Play("Walk");
        }
    }

    void Move(float move)
    {
        Vector2 movement = new Vector2(move, 0);
        rb2d.AddForce(movement * speed);
    }
    
    void Jump(bool left, bool twice=false)
    {
        if (jumpLeft > 0)
        {
            if (left)
            {
                rb2d.velocity = new Vector2(maxVelocityx, jumpHeight);
                if (twice)
                {
                    rb2d.velocity = new Vector2(maxVelocityx, jumpHeight);
                }
            }
            else
            {
                rb2d.velocity = new Vector2(-maxVelocityx, jumpHeight);
                if (twice)
                {
                    rb2d.velocity = new Vector2(-maxVelocityx, jumpHeight);
                }
            }

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
        if (move > 0)
        {
            Vector3 lTemp = transform.localScale;;
            if (lTemp.x <= 0)
            {
                lTemp.x *= -1;
                transform.localScale = lTemp;
            }
        }

        else if (move < 0)
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
