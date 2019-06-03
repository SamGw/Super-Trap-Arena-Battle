using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class life_controller : MonoBehaviour
{
    public TextMeshProUGUI life_Text1; 
    public TextMeshProUGUI life_Text2;  
    public TextMeshProUGUI life_Text3;
    public TextMeshProUGUI life_Text4;
    
    private int nb_player ;
    // Start is called before the first frame update
    void Start()
    {
        nb_player = main.numberOfPlayers;
    }

    // Update is called once per frame
    void Update()
    {
        if (nb_player >=1)
        {
            int l1 = DestroyByBoundary.life1;
            string str = l1.ToString();
            life_Text1.text = "player1 \n" +"life:"+ str ;                    
        }

        if (nb_player >=2)
        {
            int l2 = DestroyByBoundary.life2;
            string str2 = l2.ToString();
            life_Text2.text = "player2 \n" +"life:"+ str2 ;                     
        }
        else
        {
            life_Text2.text = " ";
        }

        if (nb_player >= 3)
        {           
            int l3 = DestroyByBoundary.life3;
            string str3 = l3.ToString();
            life_Text3.text = "player3 \n" +"life:"+ str3 ; 
        }
        else
        {
            life_Text3.text = " ";
        }

        if (nb_player >= 4)
        {
            int l4 = DestroyByBoundary.life4;
            string str4 = l4.ToString();
            life_Text4.text = "player4 \n" +"life:"+ str4 ;             
        }
        else
        {
            life_Text4.text = " ";
        }
    }
}
