using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPreFab;
    public Transform wordCanvas;
    

    public WordDisplay SpawnWord()
    {
        Vector3 randomPos = new Vector3(Random.Range(-2.5f, 2.5f), 7);
       

        GameObject  wordObj = Instantiate(wordPreFab, randomPos, Quaternion.identity, wordCanvas );
        WordDisplay  wordDisplay = wordObj.GetComponent<WordDisplay>();
        return wordDisplay;
    }
}
