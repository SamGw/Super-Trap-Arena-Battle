using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Kick : MonoBehaviour
{
    /// <summary>
    /// max 4 perso sur le jeu
    /// dmg clone other script percent pour l utilise dans percent
    /// </summary>
    public static int dmg1 ;
    public static int dmg2 ;
    public static int dmg3 ;
    public static int dmg4 ;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Colliders"))
        {
            if (other.transform.parent.parent.CompareTag("Player"))
            {
                PlayerMovements other_script = other.GetComponentInParent<PlayerMovements>();
                other_script.hitStun = true;
                
                other.GetComponent<PlayerMovements>();
                other_script.percent += 5;
                if (other_script.player == 1)
                {
                    dmg1 = other_script.percent;
                }
                if (other_script.player == 2)
                {
                    dmg2 = other_script.percent;
                }
                if (other_script.player == 3)
                {
                    dmg3 = other_script.percent;
                }
                if (other_script.player == 4)
                {
                    dmg4 = other_script.percent;
                }
                
                Rigidbody2D other_rb2d = other.GetComponentInParent<Rigidbody2D>();
                Transform tr = transform.parent.parent;
                float knockback;

                if (CompareTag("Attack Side"))
                {
                    knockback = tr.localScale.x * other_script.percent;
                    other_rb2d.velocity = new Vector2(knockback, other_rb2d.velocity.y);
                }
                else if (CompareTag("Attack Up"))
                {
                    knockback = other_script.percent;
                    other_rb2d.velocity = new Vector2(other_rb2d.velocity.x, knockback);
                }
            }
            else
            {
                IA other_script = other.GetComponentInParent<IA>();
                other_script.hitStun = true;
                
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

            //Ajouter pourcentage

                //

                //Knockback
               
            //Sounds effects
            
            SoundEffects.Instance.Make_FaceSound();

        }
    }
}
