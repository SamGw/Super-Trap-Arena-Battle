using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
    //Script du gameobject Boundary
    
    
    public GameObject gameController;

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            GameController myGame = gameController.GetComponent<GameController>();
            myGame.numberOfPlayers--;
        }
    }
}
