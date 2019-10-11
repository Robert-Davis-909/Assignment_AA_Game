using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show : MonoBehaviour
{
    public Text PanelName;
    public Text PanelSpeed;
    public Text PanelScore;
    public Text PanelHighScore;
    public Text PanelRounds;

    private void Awake()
    {
        PanelName.text = keepData.PlayerName;
        PanelSpeed.text = keepData.PlayerSpeed.ToString();
        PanelHighScore.text = "High: " + keepData.HighScore.ToString();
        PanelRounds.text = "Rounds: " + keepData.Rounds.ToString();
    }
    private void Update()
    {
        PanelScore.text = Score.PinCount.ToString();
        
    }
}
