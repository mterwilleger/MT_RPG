using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI treasureText;
    

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

}
