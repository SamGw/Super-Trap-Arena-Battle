using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class life : MonoBehaviour
{
    public TextMeshProUGUI life_Text1; 
    public TextMeshProUGUI life_Text11; 
    public TextMeshProUGUI life_Text2;  
    public TextMeshProUGUI life_Text21;  
    public TextMeshProUGUI life_Text3;
    public TextMeshProUGUI life_Text31;
    public TextMeshProUGUI life_Text4;
    public TextMeshProUGUI life_Text41;

    public Image coeur1;
    public Image coeur2;
    public Image coeur3;
    public Image coeur4;
    
    private int nb_player ;
    // Start is called before the first frame update
    void Start()
    {
        nb_player = main.numberOfPlayers;
        coeur1.enabled = false;
        coeur2.enabled = false;
        coeur3.enabled = false;
        coeur4.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (nb_player >=1)
        {
            coeur1.enabled = true;
            life_Text1.text = "P1" ;   
            int l1 = DestroyByBoundary.life1;
            string str = l1.ToString();
            life_Text11.text = str;

        }

        if (nb_player >=2)
        {
            coeur2.enabled = true;
            life_Text2.text = "P2" ;   
            int l2 = DestroyByBoundary.life2;
            string str = l2.ToString();
            life_Text21.text = str;                     
        }
        else
        {
            life_Text2.text = " ";
            life_Text21.text = " ";
        }

        if (nb_player >= 3)
        {        
            
            coeur3.enabled = true;
            life_Text3.text = "P3" ;   
            int l3 = DestroyByBoundary.life3;
            string str = l3.ToString();
            life_Text31.text = str;                     
        }
        else
        {
            life_Text3.text = " ";
            life_Text31.text = " ";
        }

        if (nb_player >= 4)
        {
            coeur4.enabled = true;
            life_Text4.text = "P4" ;   
            int l4 = DestroyByBoundary.life4;
            string str = l4.ToString();
            life_Text41.text = str;                     
        }
        else
        {
            life_Text4.text = " ";
            life_Text41.text = " ";
        }
    }
}
