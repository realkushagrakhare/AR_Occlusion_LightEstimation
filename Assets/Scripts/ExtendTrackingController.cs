using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtendTrackingController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3 tpos = transform.position;
		transform.parent = null;
		transform.position = tpos;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
