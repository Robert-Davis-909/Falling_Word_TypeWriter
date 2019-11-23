using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowScore : MonoBehaviour
{
    public Text scoreText;
    public Text missedText;
    public Text highScoreText;

    private void Awake()
    {
        scoreText.text = "Score: " + WordDisplay.correct.ToString();
        missedText.text = "Words missed: " + WordDisplay.missed.ToString();
        highScoreText.text = "High Score: " + WordDisplay.highscore.ToString();
    }

    // Update is called once per frame
    private void Update()
    {
        scoreText.text = "Score: " + WordDisplay.correct.ToString();
        missedText.text = "Words missed: " + WordDisplay.missed.ToString();
        highScoreText.text = "High Score: " + WordDisplay.highscore.ToString();
    }
}
