using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextEvent : MonoBehaviour
{
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void quitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

   public void PlayGame()
    {
        SceneManager.LoadScene("MainLevel");
    }
    

    public void EndGame()
    {
        SceneManager.LoadScene("End");
    }

    public void GoBack()
    {
        SceneManager.LoadScene("Instructions");
    }
}
