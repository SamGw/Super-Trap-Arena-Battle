<<<<<<< HEAD:STAB/Assets/Scripts/Brawl/PlayerMovements.cs
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
    public int percent = 0;

    private float moveHorizontal;
    private int jumpLeft = 2;
    private bool wantJump;
    private bool wantAttack;
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
        wantAttack = Input.GetKeyDown(attacKey);
    }

    void SelectAnimation()
    {
        anim.SetFloat("hSpeed",Mathf.Abs(moveHorizontal));
        anim.SetBool("attack", wantAttack);
        anim.SetFloat("vSpeed", rb2d.velocity.y);
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
            || other.collider.CompareTag("Side_R")
            || other.collider.CompareTag("Colliders"))
        {
            jumpLeft = 2;
            anim.SetBool("inAir", false);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ground")
            || other.collider.CompareTag("Side_L")
            || other.collider.CompareTag("Side_R")
            || other.collider.CompareTag("Colliders"))
        {
            anim.SetBool("inAir", true);
        }
    }
}
=======
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
    private bool wantAttack;
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
        wantAttack = Input.GetKeyDown(attacKey);
    }

    void SelectAnimation()
    {
        anim.SetFloat("hSpeed",Mathf.Abs(moveHorizontal));
        anim.SetBool("attack", wantAttack);
        anim.SetFloat("vSpeed", rb2d.velocity.y);
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
            || other.collider.CompareTag("Side_R")
            || other.collider.CompareTag("Colliders"))
        {
            jumpLeft = 2;
            anim.SetBool("inAir", false);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ground")
            || other.collider.CompareTag("Side_L")
            || other.collider.CompareTag("Side_R")
            || other.collider.CompareTag("Colliders"))
        {
            anim.SetBool("inAir", true);
        }
    }
}
>>>>>>> d624f5ee2f32a5cd69ffffd25e44f7c22a46e2d7:STAB/Assets/Scripts/Brawl/PlayerMovements.cs
