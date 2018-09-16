using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	
    public static string TimerClock(float currentTime)
    {
        int intTime = (int)currentTime;
        int minutes = intTime / 60;
        int seconds = intTime % 60;
        float fraction = currentTime * 1000;
        fraction = (fraction % 100);
        string timeText = string.Format("{0:00}:{1:00}.{2:00}", minutes, seconds, fraction);
        return timeText;
    }

}
