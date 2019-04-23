<<<<<<< HEAD
﻿using System.Collections;
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
=======
﻿using System.Collections;
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
>>>>>>> d624f5ee2f32a5cd69ffffd25e44f7c22a46e2d7
