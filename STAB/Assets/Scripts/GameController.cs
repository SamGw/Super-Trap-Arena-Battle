using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public GameObject PersoCubique;
	public GameObject Bot;
	public int numberOfPlayers = 3;
	
    // Start is called before the first frame update
    void Start()
    {	
	    //A faire : liste, objectif : automatiser selon le nb de joueur
	    
    	GameObject P1 = Instantiate(PersoCubique,new Vector3(-1,0,0),new Quaternion(0f,0f,0f,0f));
        GameObject P2 = Instantiate(PersoCubique, new Vector3(1,0,0),new Quaternion(0f,0f,0f,0f));
	    GameObject P3 = Instantiate(PersoCubique, new Vector3(0,0,0),new Quaternion(0f,0f,0f,0f));
	    GameObject Bot1 = Instantiate(Bot, new Vector3(0,0,0),new Quaternion(0f,0f,0f,0f));

        PlayerMovements P1_script = P1.GetComponent<PlayerMovements>();
        PlayerMovements P2_script = P2.GetComponent<PlayerMovements>();
	    PlayerMovements P3_script = P3.GetComponent<PlayerMovements>();
	    IA Bot1_script = Bot1.GetComponent<IA>();
	    
        P1_script.player = 1;
        P2_script.player = 2;
	    P3_script.player = 3;
    }

    // Update is called once per frame
    void Update()
    {
	    if (numberOfPlayers <= 1 && Input.GetKeyDown(KeyCode.R))
	    {
		    SceneManager.LoadScene("Brawl Scene");
	    }
    }
}
