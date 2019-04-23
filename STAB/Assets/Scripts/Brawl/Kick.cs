using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Kick : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Colliders"))
        {
            if (other.transform.parent.parent.CompareTag("Player"))
            {
                PlayerMovements other_script = other.GetComponentInParent<PlayerMovements>();
                other_script.hitStun = true;
            }
            else
            {
                IA other_script = other.GetComponentInParent<IA>();
                other_script.hitStun = true;
            }

            //Ajouter pourcentage

                //

                //Knockback
                Rigidbody2D other_rb2d = other.GetComponentInParent<Rigidbody2D>();
                Transform tr = transform.parent.parent;
                float knockback;

                if (CompareTag("Attack Side"))
                {
                    knockback = tr.localScale.x * 40;
                    other_rb2d.velocity = new Vector2(knockback, other_rb2d.velocity.y);
                }
                else if (CompareTag("Attack Up"))
                {
                    knockback = 40;
                    other_rb2d.velocity = new Vector2(other_rb2d.velocity.x, knockback);
                }
            

        }
    }
}
