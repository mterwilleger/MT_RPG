using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI chestText;
    public TextMeshProUGUI gemText;

    //instance
    public static GameUI instance;

    void Awake ()
    {
        instance = this;
    }

    public void UpdateGoldText (int gold)
    {
        goldText.text = "<b>Gold:</b> " + gold;
    }

    public void UpdateChestText (int chest)
    {
        chestText.text = "<b>Chest:</b> " + chest;
    }

    public void UpdateGemText (int gem)
    {
        gemText.text = "<b>Gems:</b> " + gem;
    }

}
