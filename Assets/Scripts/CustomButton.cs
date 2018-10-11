using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CustomButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	public Controller playerController;
	public int xDir = 0;
	public int yDir = 0;

	bool _pressed = false;
	public void OnPointerDown(PointerEventData eventData) {
		_pressed = true;
	}

	public void OnPointerUp(PointerEventData eventData) {
		_pressed = false;
	}

	void Update() {
		if (!_pressed)
			return;
		if (Mathf.Abs (xDir) == 0) {
			playerController.TranslateY (yDir);
		} else {
			playerController.TranslateX (xDir);
		}
	}
}
