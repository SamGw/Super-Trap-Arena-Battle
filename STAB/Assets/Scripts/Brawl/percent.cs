﻿using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;

public class percent : MonoBehaviour
{     
    public Text percent_Text1; 
    public Text percent_Text2;  
    public Text percent_Text3;
    public Text percent_Text4;
    
    public Color newcolor1;
    public Color newcolor2;
    public Color newcolor3;
    public Color newcolor4;

    private int nb_player ;
    // Update is called once per frame
    private void Start()
    {
        nb_player = main.numberOfPlayers;
       
    }
   
    void Update()
    {
        if (nb_player >=1)
        {
            float d1 = Kick.dmg1;
            string str = d1.ToString();
            percent_Text1.text = "player1 \n" + str + "%";          
            if ( d1 <= 70)
            {
                newcolor1 = new Color(1,1-(d1/70),1-(d1/70),1);
                percent_Text1.color = newcolor1;
            }
 
        }

        if (nb_player >=2)
        {
            float d2 = Kick.dmg2;
            string str2 = d2.ToString();
            percent_Text2.text = "player2 \n" + str2 + "%"; 
            if ( d2 <= 70)
            {
                newcolor2 = new Color(1,1-(d2/70),1-(d2/70),1);
                percent_Text2.color = newcolor2;
            }
          
        }
        else
        {
            percent_Text2.text = " ";
        }

        if (nb_player >= 3)
        {           
            float d3 = Kick.dmg3;
            string str3 = d3.ToString();
            percent_Text3.text = "player3 \n" + str3 + "%"; 
            if ( d3 <= 70)
            {
                newcolor3 = new Color(1,1-(d3/70),1-(d3/70),1);
                percent_Text3.color = newcolor3;
            }
        
        }
        else
        {
            percent_Text3.text = " ";
        }

        if (nb_player >= 4)
        {
            float d4 = Kick.dmg4;
            string str4 = d4.ToString();
            percent_Text4.text = "player4 \n" + str4 + "%"; 
            if ( d4 <= 70)
            {
                newcolor4 = new Color(1,1-(d4/70),1-(d4/70),1);
                percent_Text4.color = newcolor4;
            }
        }
        else
        {
            percent_Text4.text = " ";
        }
       // percent_Text1.color = newcolor1;
        
       
        
       
    }
}
