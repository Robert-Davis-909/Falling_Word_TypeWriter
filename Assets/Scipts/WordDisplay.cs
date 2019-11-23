using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public static float fallingSpeed = 1f;
    public static int correct = 0;
    public static int missed = 0;
    public static int highscore = 0;

    public AudioClip newSound;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SetWord( string word)
    {
        text.text = word;
        text.color = KeepData.ColorOfWord;

    }

    public void RemoveLetter()
    {
        audioSource.PlayOneShot(newSound);
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        correct++;
            if(correct > highscore)
        {
            highscore = correct;
        }
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "wall")
        {
            missed++;
        }
    }

    private void Update()
    {
        transform.Translate(0f, -fallingSpeed * Time.deltaTime * KeepData.wordSpeedMultiplier, 0f);
    }
}
