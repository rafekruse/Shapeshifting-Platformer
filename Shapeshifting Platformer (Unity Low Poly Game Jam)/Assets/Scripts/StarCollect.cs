using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollect : MonoBehaviour {

   public GameObject[] stars;

   void OnCollisionEnter(Collision col)
    {

        foreach (GameObject star in stars)
        {
            if (!star.activeSelf)
            {
                star.SetActive(true);
                break;                
            }
        }
        Destroy(gameObject);
    }

}
