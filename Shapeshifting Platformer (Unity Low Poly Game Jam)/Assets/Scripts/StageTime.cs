using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageTime : MonoBehaviour {

    public float timeElapsed;
    public float timeToCompleteLevel;
    public float timeRemaining;
    

    private bool dead;


    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
        timeRemaining = timeToCompleteLevel;
	}
	
	// Update is called once per frame
	void Update () {
        timeElapsed += Time.deltaTime;
        timeRemaining -= Time.deltaTime;
        PersistentManagerScript.Globals.sliders.transform.Find("Crystal Slide").GetComponent<Slider>().value = timeRemaining / timeToCompleteLevel;

        if(timeRemaining < 0 && !dead)
        {
            StageFail.Failure();
            dead = true;
        }
	}
}
