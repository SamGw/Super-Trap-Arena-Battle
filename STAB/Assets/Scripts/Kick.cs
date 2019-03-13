using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //HITSTUN
            
            PlayerMovements other_script = other.GetComponent<PlayerMovements>();
            other_script.hitStun = true;
            
            //Ajouter pourcentage
            
            //
            
            //Knockback
            Rigidbody2D other_rb2d = other.GetComponent<Rigidbody2D>();
            Transform tr = transform.parent;

            float knockback = tr.localScale.x * 40;
            
            Debug.Log(tr.localScale.x);
            other_rb2d.velocity = new Vector2(knockback ,other_rb2d.velocity.y);
        }
    }
}
