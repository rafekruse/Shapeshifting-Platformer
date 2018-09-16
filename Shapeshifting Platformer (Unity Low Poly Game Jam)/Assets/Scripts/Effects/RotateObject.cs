using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

    public Vector3 startRotation;
    private float currentRotationAngleInDegrees;
    public float degreesPerSecond;

	
	// Update is called once per frame
	void Update () {

        currentRotationAngleInDegrees += degreesPerSecond * Time.deltaTime;

        transform.eulerAngles = new Vector3(startRotation.x, currentRotationAngleInDegrees, startRotation.z);

        if(currentRotationAngleInDegrees >= 360)
        {
            currentRotationAngleInDegrees = 0;
        }

	}
}
