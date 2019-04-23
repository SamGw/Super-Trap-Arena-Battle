<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Kick : MonoBehaviour
{
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
            //Sounds effects
            
            SoundEffects.Instance.Make_FaceSound();

        }
    }
}
=======
﻿using System.Collections;
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
            //Sounds effects
            
            SoundEffects.Instance.Make_FaceSound();

        }
    }
}
>>>>>>> d624f5ee2f32a5cd69ffffd25e44f7c22a46e2d7
