using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CameraFocusController : MonoBehaviour {

	private bool on = true;
	void Start() {    
		var vuforia = VuforiaARController.Instance;    
		vuforia.RegisterVuforiaStartedCallback(OnVuforiaStarted);    
		vuforia.RegisterOnPauseCallback(OnPaused);
	}  

	private void OnVuforiaStarted() {    
		CameraDevice.Instance.SetFocusMode(
			CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
	}

	private void OnPaused(bool paused) {    
		if (!paused) // resumed
		{
			// Set again autofocus mode when app is resumed
			CameraDevice.Instance.SetFocusMode(
				CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);    
		}
	}
	public void Switch(){
		on = !on;
		if (on) {
			CameraDevice.Instance.Stop ();
			CameraDevice.Instance.Deinit ();
			TrackerManager.Instance.GetTracker<ObjectTracker> ().Stop ();
			CameraDevice.Instance.Init (CameraDevice.CameraDirection.CAMERA_BACK);
			CameraDevice.Instance.Start ();
			TrackerManager.Instance.GetTracker<ObjectTracker> ().Start ();
		} else {
			CameraDevice.Instance.Stop ();
			CameraDevice.Instance.Deinit ();
			TrackerManager.Instance.GetTracker<ObjectTracker> ().Stop ();
			CameraDevice.Instance.Init (CameraDevice.CameraDirection.CAMERA_FRONT);
			CameraDevice.Instance.Start ();
			TrackerManager.Instance.GetTracker<ObjectTracker> ().Start ();
		}
	}
}
