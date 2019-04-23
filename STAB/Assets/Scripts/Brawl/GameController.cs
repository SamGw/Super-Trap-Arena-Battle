using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public List<GameObject> Characters;
	public int numberOfPlayers;
	
    // Start is called before the first frame update
    void Start()
    {
	    numberOfPlayers = main.numberOfPlayers;
	    //Liste pour automatiser l'instanciation selon le nb de joueur

	    for (int i = 0; i < numberOfPlayers; i++)
	    {
		    GameObject P = Instantiate(Characters[SelectionController.selectedCharacters[i]],
			    new Vector3(i-1,0,0),new Quaternion(0f,0f,0f,0f));
		    P.name = "Player " +(i + 1);
		    PlayerMovements P_script = P.GetComponent<PlayerMovements>();
		    P_script.player = i+1;
	    }
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
