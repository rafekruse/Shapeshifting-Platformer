﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public GameObject go;

    public void DestroyCurrentObject()
    {
        Destroy(go);
    }

}
