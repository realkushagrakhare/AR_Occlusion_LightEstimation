using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	// Use this for initialization
	public float speed = 15f;

	public void TranslateX(int direction) {
		if (direction == 1)
			transform.rotation = Quaternion.Euler (Vector3.zero);
		else
			transform.rotation = Quaternion.Euler (transform.up * 180f);
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}

	public void TranslateY(int direction) {
		transform.rotation = Quaternion.Euler (transform.up * direction * 90f);
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}
}
