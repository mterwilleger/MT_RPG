using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI treasureText;
    public TextMeshProUGUI winText;
    public Image winBackground;
    

    //instance
    public static GameUI instance;

    void Awake ()
    {
        instance = this;
    }
    
    public void UpdateTreasureText (int treasure)
    {
        treasureText.text = "<b>Treasure:</b> " + treasure;
    }

    public void SetWinText (string winnerName)
    {
        winBackground.gameObject.SetActive(true);
        winText.text = winnerName + " wins!";
    }

}
