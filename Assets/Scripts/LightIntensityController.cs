using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensityController : MonoBehaviour {

	// Use this for initialization

	[SerializeField] private float initialLightIntensity = 1f;
	[SerializeField] private float maxSceneIntensity = 100f;
	public float curSceneIntensity = 0f;

	Light lt;
	LightSensorPluginScript test;

	void Start () {
		test = GetComponent<LightSensorPluginScript> ();
		lt = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		curSceneIntensity = test.getLux ();
		lt.intensity = initialLightIntensity * (curSceneIntensity / 100f);
		Debug.Log (lt.intensity);
	}
}
