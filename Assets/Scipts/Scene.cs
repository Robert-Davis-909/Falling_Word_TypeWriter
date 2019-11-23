using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void Stop()
    {
        SceneManager.LoadScene("Exit");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro");
    }

    public void Exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
