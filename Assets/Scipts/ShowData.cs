using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text playerNameText;
    public Text wordSpeedText;

    
    void Update()
    {
        playerNameText.text = KeepData.playerName;
        wordSpeedText.text = KeepData.wordSpeedMultiplier.ToString();
    }
}
