using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {
    
    public bool paused;    
	
    void Start()
    {
        Time.timeScale = 1;
        paused = false;
        PersistentManagerScript.Globals.pauseScreen.SetActive(false);
    }

	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape) && !paused)
        {
            Time.timeScale = 0;
            paused = true;
            PersistentManagerScript.Globals.pauseScreen.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && paused)
        {
            Time.timeScale = 1;
            paused = false;
            PersistentManagerScript.Globals.pauseScreen.SetActive(false);
        }

	}
}
