using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSwapScript : MonoBehaviour {

    
    public bool foxTrueBirdFalse = false;
    
	// Use this for initialization
	void Start () {

        PersistentManagerScript.Globals.bird.SetActive(false);
              
        	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (foxTrueBirdFalse){
                SwitchForms(PersistentManagerScript.Globals.fox, PersistentManagerScript.Globals.bird, PersistentManagerScript.Globals.poof);
                foxTrueBirdFalse = false;
            }
            else if (!foxTrueBirdFalse){
                SwitchForms(PersistentManagerScript.Globals.bird, PersistentManagerScript.Globals.fox, PersistentManagerScript.Globals.poof);
                foxTrueBirdFalse = true;
            }
        }

	}

    public static void SwitchForms(GameObject currentForm, GameObject newForm)
    {
        if(currentForm == PersistentManagerScript.Globals.bird)
        {
           if(Physics.Raycast(currentForm.transform.position, Vector3.down, 2))
            {
                newForm.transform.position = new Vector3(currentForm.transform.position.x, currentForm.transform.position.y + 1.5f, currentForm.transform.position.z);
            }
        }

        newForm.transform.position = currentForm.transform.position;
        newForm.transform.rotation = currentForm.transform.rotation;

        newForm.SetActive(true);
        currentForm.SetActive(false);
        
        newForm.GetComponent<Rigidbody>().velocity = currentForm.GetComponent<Rigidbody>().velocity;
    }
    public static void SwitchForms(GameObject currentForm, GameObject newForm, ParticleSystem transformationParticleEffect)
    {
        SwitchForms(currentForm, newForm);
        Instantiate(transformationParticleEffect, newForm.transform.position, Quaternion.identity);
        transformationParticleEffect.Play();
    }
    
}
