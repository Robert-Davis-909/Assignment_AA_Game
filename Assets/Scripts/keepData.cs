using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keepData : MonoBehaviour
{
    public static string PlayerName = "Random Player";
    public static int PlayerScore;// link to the old game somehow?
    public static int HighScore = 0;
    public static float PlayerSpeed;
    public static int Rounds = 0;

    public InputField NameInput;
    public Slider SpeedofGame;
    
    // don't forget to fill these fields in the inspector for data manager

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //don't destroy when new scene is loaded

    }
    private void Update()
    {
        //Debug.Log(PlayerName + " has " + PlayerLives + " lives and " + PlayerSpeed + " speed and score of " + PlayerScore);
    }
   
    public void UpdateName()
    {
        PlayerName = NameInput.text;

    }

    public void ChangeSpeed()
    {
        PlayerSpeed = SpeedofGame.value;
    }
}
