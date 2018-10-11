using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	// Use this for initialization
	public float speed = 15f;

	public void TranslateX(int direction) {
		transform.Translate (Vector3.forward * direction * speed * Time.deltaTime);
	}

	public void TranslateY(int direction) {
		transform.Translate (Vector3.right * direction * speed * Time.deltaTime);
	}
}
