using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D body;
    private bool exploded;
    public float knockback = 40;
    private void Start()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            body.bodyType = RigidbodyType2D.Static;
            anim.SetBool("explosion", true);
        }
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("Pite");
                        
            PlayerMovements other_script = other.GetComponent<PlayerMovements>();
            other_script.hitStun = true;
            
            Rigidbody2D other_rb2d = other.GetComponent<Rigidbody2D>();
            Transform tr = transform.parent;
            if (other.transform.position.x < body.position.x)
                knockback *= -1;
            other_rb2d.velocity = new Vector2(knockback , 10);
        }
    }
    
    void kill()
    {
        Destroy(gameObject);
    }
}
