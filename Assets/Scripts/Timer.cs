using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Code heavily inspired by N3K EN from YouTube
// https://www.youtube.com/watch?v=x-C95TuQtf0

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    public static string minutes { get; set; }
    public static string seconds { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // Updates the time every frame
        float t = Time.time - startTime;

        minutes = ((int)t / 60).ToString();
        seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }
}
