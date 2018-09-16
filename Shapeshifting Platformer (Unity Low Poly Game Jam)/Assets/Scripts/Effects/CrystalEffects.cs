using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalEffects : MonoBehaviour {

    public float minScale;
    public float maxScale;
    public float minEmission;
    public float maxEmission;
    public float pulseSpeed;
    private MeshRenderer meshRend;
    private Transform trans;


	void Start () {
        meshRend = this.GetComponent<MeshRenderer>();
        trans = this.GetComponent<Transform>();
	}
	

	void Update () {
        float scaleEmissionRatio = (maxEmission - minEmission) / (maxScale - minScale);

        float scale = minScale + Mathf.PingPong(Time.time * pulseSpeed, maxScale - minScale);
        float emission = minEmission + Mathf.PingPong(Time.time * pulseSpeed * scaleEmissionRatio, maxEmission - minEmission);           
        
        Color baseColor = new Color(1, .5f, 0);
        Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);

        trans.localScale = new Vector3(scale, scale, scale);
        meshRend.material.SetColor("_EmissionColor", finalColor);
	}
}
