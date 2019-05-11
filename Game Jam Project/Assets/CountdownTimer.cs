using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    // Start is called before the first frame update

    public Text timerText;
    private float time = 10f;

    void Start()
    {
        StartCoundownTimer();
    }

    void Update()
    {
        if (timerText != null)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                timerText.text = "Time Left: 00:00";
                time = 10f;
            }
            else
            {
                string minutes = Mathf.Floor(time / 60).ToString("00");
                string seconds = (time % 60).ToString("00");
                timerText.text = "Time Left: " + minutes + ":" + seconds;
            }
        }
    }

    void StartCoundownTimer()
    {
        timerText = GetComponent<Text>();

        if (timerText != null)
        {
            time = 10;
            timerText.text = "Time Left: 00:10";
        }
    }
}