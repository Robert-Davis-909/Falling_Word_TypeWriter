using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public static string playerName = "Player name";
    public static float wordSpeedMultiplier = 1.0f;
    public InputField playerNameInput;
    public Slider wordSpeed;
    public static Color ColorOfWord = Color.white;
    public Dropdown wordColor;
    
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName()
    {
        playerName = playerNameInput.text;
    }
    public void SetSpeed()
    {
        wordSpeedMultiplier = wordSpeed.value;
    }
    

    public void SetColorOfWord()
    {
        switch (wordColor.value)
        {
            case 1:
                ColorOfWord = Color.gray;
                break;
            case 2:
                ColorOfWord = Color.yellow;
                break;
        }
    }
}
