using UnityEngine;
using System;
using System.Collections;

public class LightSensorPluginScript : MonoBehaviour {
	private AndroidJavaObject activityContext = null;
	private AndroidJavaObject jo = null;
	AndroidJavaClass activityClass = null;

	void Start () {
		#if UNITY_ANDROID
		activityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		activityContext = activityClass.GetStatic<AndroidJavaObject>("currentActivity");

		jo = new AndroidJavaObject("com.etiennefrank.lightsensorlib.LightSensorLib");
		jo.Call("init", activityContext);
		#endif
	}

	public float getLux() {
		#if UNITY_ANDROID
		return jo.Call<float>("getLux");
		#endif
	}
}
