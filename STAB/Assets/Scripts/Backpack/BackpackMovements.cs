using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackMovements : MonoBehaviour
{
    public float initialVelocityX;
    
    private Rigidbody2D rb2d;
    private Animator anim;
    
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        rb2d.velocity = new Vector2(initialVelocityX, 2f);
    }
    // Update is called once per frame
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Colliders"))
        {
            anim.SetBool("IsTriggered", true);
        }
    }
}
