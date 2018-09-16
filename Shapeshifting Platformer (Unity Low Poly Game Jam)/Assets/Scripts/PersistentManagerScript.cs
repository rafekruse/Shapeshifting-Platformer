using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentManagerScript : MonoBehaviour
{

    public static PersistentManagerScript Globals { get; private set; }

    public GameObject swapper;
    public GameObject fox;
    public GameObject bird;

    public GameObject canvas;
    public GameObject sliders;
    public GameObject failScreen;
    public GameObject endScreen;
    public GameObject pauseScreen;
    
    
    public ParticleSystem poof;
    public ParticleSystem blood;
    public bool isPersistant;

    private void Awake()
    {
        if (isPersistant)
        {
            if (Globals == null)
            {
                Globals = this;
            }
            else
            {
                Destroy(gameObject);

            }
        }
    }
}
