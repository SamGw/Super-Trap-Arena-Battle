using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DestroyByBoundary : MonoBehaviour
{
    public static int life1 = 3 ;
    public static int life2  = 3;
    public static int life3  = 3;
    public static int life4  = 3;
    //Script du gameobject Boundary
    public List<GameObject> Characters;
    
    public GameObject gameController;

    void OnTriggerExit2D(Collider2D other)
    {
       
        GameController myGame = gameController.GetComponent<GameController>();
        if (other.CompareTag("Player"))
        {
            
           // PlayerMovements otherScript = other.GetComponent<PlayerMovements>();
            
           // GameObject P = other.gameObject;
            PlayerMovements p1 = other.GetComponent<PlayerMovements>();
            
           
            if (p1.life > 1)
            {
                p1.life -= 1;
                p1.percent = 0;

               GameObject P = Instantiate(other.gameObject, new Vector3(p1.player, 0, 0), new Quaternion(0f, 0f, 0f, 0f));
               PlayerMovements p = P.GetComponent<PlayerMovements>();
               Destroy(other.gameObject);
                //le recreate
            }
            else
            {
                Destroy(other.gameObject);
                p1.life -= 1;

                myGame.numberOfPlayers--;
            }
            switch (p1.player)
            {
                case 1:
                    life1 = p1.life;
                    Kick.dmg1 = 0;
                    break;
                case 2:
                    life2 = p1.life;
                    Kick.dmg2 = 0;
                    break;
                case 3:
                    life3 = p1.life;
                    Kick.dmg3 = 0;
                    break;
                case 4:
                    life4 = p1.life;
                    Kick.dmg4 = 0;
                    break;
            }

           
        }

        if (myGame.numberOfPlayers <= 1)
        {
            //change scene winner
            SceneManager.LoadScene("endscene");
        }
    }
}
