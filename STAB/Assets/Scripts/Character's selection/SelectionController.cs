using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectionController : MonoBehaviour
{
    public static int numberOfPlayers = 2;
    public static List<int> selectedCharacters;
    
    public TextMeshProUGUI txtPlayer;
    public GameObject screen;

    private int currentPlayer = 1;
    private TextMeshProUGUI numPlayer;
    private RectTransform myRectTransform;
    void Start()
    {
        txtPlayer.text = "Player 1";
        selectedCharacters = new List<int>();
    }

    private void Update()
    {
        if (currentPlayer > numberOfPlayers)
        {
            SceneManager.LoadScene("Brawl Scene");
        }
    }

    public void GetRectTransform(RectTransform rectTransform)
    {
        myRectTransform = rectTransform;
    }
    public void Select(int selectedNum)
    {
        selectedCharacters.Add(selectedNum);
        if(currentPlayer <= numberOfPlayers)
            display();
        
        currentPlayer++;
        if(currentPlayer <= numberOfPlayers)
            txtPlayer.text = "Player " + currentPlayer;
    }

    private void display()
    {
        GameObject n1 = new GameObject("Player Plate" + currentPlayer);
        n1.transform.SetParent(screen.transform);
        
        n1.AddComponent<TextMeshProUGUI>();
        RectTransform rect = n1.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(60,55);
        rect.localScale = new Vector3(1,1,1);
        rect.position = new Vector3(0.5f + myRectTransform.position.x + 0.5f * currentPlayer,
            myRectTransform.position.y - 0.5f,0);
        
        numPlayer = n1.GetComponent<TextMeshProUGUI>();
        numPlayer.fontSize = 45f;
        numPlayer.text = string.Format("[{0}]", currentPlayer);
    }
    
    
    
}
