using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text Score;

    // A script to support the timer for the end screen
    void Update()
    {
        Score.text = "Time Lasted: " + Timer.minutes + ":" + Timer.seconds;
    }

}
