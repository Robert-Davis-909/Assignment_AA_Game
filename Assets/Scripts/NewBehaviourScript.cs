using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{
    public Text HighScore;

    void Start()
    {
        HighScore.text = Score.PinCount.ToString();
    }

    void Update()
    {
        
    }
}
