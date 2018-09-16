using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageEnd : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        Time.timeScale = 0;
        PersistentManagerScript.Globals.sliders.SetActive(false);
        PersistentManagerScript.Globals.endScreen.transform.Find("Timer").GetComponent<Text>().text = Timer.TimerClock(PersistentManagerScript.Globals.swapper.GetComponent<StageTime>().timeElapsed);
        PersistentManagerScript.Globals.endScreen.SetActive(true);
    }

}
