﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterDelay : MonoBehaviour { 

    public float delay;
    void Start()
    {
        Destroy(gameObject, delay);
    }
}
