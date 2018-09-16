using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageFail : MonoBehaviour {
    


	void OnCollisionEnter(Collision col)
    {
        Failure();
    }
    public static void Failure()
    {
        foreach (SkinnedMeshRenderer mr in PersistentManagerScript.Globals.swapper.GetComponentsInChildren<SkinnedMeshRenderer>())
        {
            mr.enabled = false;      
        }
        foreach(Rigidbody rb in PersistentManagerScript.Globals.swapper.GetComponentsInChildren<Rigidbody>())
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
        if (PersistentManagerScript.Globals.swapper.GetComponentInChildren<FoxMovement>() != null)
        {
            PersistentManagerScript.Globals.swapper.GetComponentInChildren<FoxMovement>().enabled = false;
        }
        if (PersistentManagerScript.Globals.swapper.GetComponentInChildren<BirdMovement>() != null)
        {
            PersistentManagerScript.Globals.swapper.GetComponentInChildren<BirdMovement>().enabled = false;
        }

        if(PersistentManagerScript.Globals.swapper.transform.Find("Fox").gameObject.activeSelf != false)
        {
            Instantiate(PersistentManagerScript.Globals.blood, PersistentManagerScript.Globals.swapper.transform.Find("Fox").position, Quaternion.Euler(90, 0 ,0)); 
        }
        else
        {
            Instantiate(PersistentManagerScript.Globals.blood, PersistentManagerScript.Globals.swapper.transform.Find("Bird").position, Quaternion.Euler(90, 0, 0));
        }
              
        PersistentManagerScript.Globals.sliders.SetActive(false);
        PersistentManagerScript.Globals.failScreen.SetActive(true);
    }

}
