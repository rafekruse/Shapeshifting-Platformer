using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class SpeedPowerUp : MonoBehaviour {
    
    public float foxPercentageChange;
    public float birdPercentageChange;
    public float duration;
    private MeshRenderer meshrenderer;
    private Collider collide;
    private FoxMovement fm;
    private BirdMovement bm;
    private float startBirdSpeed;
    private float startFoxSpeed;

   void Start()
    {
        collide = GetComponent<Collider>();
        meshrenderer = GetComponent<MeshRenderer>();
        fm = PersistentManagerScript.Globals.swapper.GetComponentInChildren<FoxMovement>(true);
        bm = PersistentManagerScript.Globals.swapper.GetComponentInChildren<BirdMovement>(true);
        startBirdSpeed = bm.Maxspeed;
        startFoxSpeed = fm.speed;
        
    }

    void OnCollisionEnter(Collision col)
    {
        bm.Maxspeed = bm.Maxspeed + (bm.Maxspeed * (birdPercentageChange / 100));
        fm.speed = fm.speed + (fm.speed * (foxPercentageChange / 100));
        collide.enabled = false;
        meshrenderer.enabled = false;
        SpeedDuration(duration);
        StartCoroutine(SpeedDuration(duration));

    }

    IEnumerator SpeedDuration(float timer)
    {
        yield return new WaitForSeconds(timer);
        fm.speed = startFoxSpeed;
        bm.Maxspeed = startBirdSpeed;
    }
}
