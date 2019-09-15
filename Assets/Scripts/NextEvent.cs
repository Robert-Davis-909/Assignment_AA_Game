﻿using System.Collections;
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

    public void SlowSpeed()
    {
        Rotator.speed = 25f;
        SceneManager.LoadScene("MainLevel");
    }

    public void MediumSpeed()
    {
        Rotator.speed = 75f;
        SceneManager.LoadScene("MainLevel");
    }

    public void FastSpeed()
    {
        Rotator.speed = 150f;
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
