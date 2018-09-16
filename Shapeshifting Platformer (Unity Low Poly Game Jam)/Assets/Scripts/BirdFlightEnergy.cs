using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdFlightEnergy : MonoBehaviour {

    AnimalSwapScript animalss;

    public float flightTime;
    public float regenerationRate;
    public float degenerationRate;
    public float regenerationStartDelay;
    public float currentFlightPower;
        
    public bool recharging = false;


	// Use this for initialization
	void Start () {
        currentFlightPower = flightTime;
        animalss = this.GetComponent<AnimalSwapScript>();
	}
    
    void Update() {

        if (PersistentManagerScript.Globals.bird.activeInHierarchy)
            currentFlightPower -= Time.deltaTime * degenerationRate;        //degeneration
        
         
        if (PersistentManagerScript.Globals.bird.activeInHierarchy && currentFlightPower < 3) // regeneration
            StartCoroutine(RechargeTimer(regenerationStartDelay));


        if (recharging)
        {
            currentFlightPower += Time.deltaTime * regenerationRate;
            if (currentFlightPower >= flightTime)
            {
                recharging = false;
            }
            if (PersistentManagerScript.Globals.bird.activeInHierarchy)
            {
                recharging = false;
            }
        }


        if (currentFlightPower <= 0 && PersistentManagerScript.Globals.bird.activeInHierarchy){
            AnimalSwapScript.SwitchForms(PersistentManagerScript.Globals.bird, PersistentManagerScript.Globals.fox, PersistentManagerScript.Globals.poof);
            animalss.foxTrueBirdFalse = true;
        }
        PersistentManagerScript.Globals.sliders.transform.Find("Energy Slide").GetComponent<Slider>().value = currentFlightPower * (1 / flightTime);
	}


    IEnumerator RechargeTimer(float delay)
    {        
        yield return new WaitForSeconds(delay);
        recharging = true;
    }
}
