using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitObject : MonoBehaviour {

    public Transform centerObject;
    public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        centerObject.RotateAround(centerObject.position, Vector3.up, rotationSpeed);
	}
}
