/*
 * Date: 15.08.2016
 * Author: Etienne Frank
 * Website: www.etiennefrank.com
 * Mail: mail@etiennefrank.com
 * Info: Feel free to use it in any project. It would be pleased to mention the author name.
 * 	     By the way the author can be hired.
 *
*/

package com.etiennefrank.lightsensorlib;

import android.content.Context;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;

public class LightSensorLib{

    private SensorManager mSensorManager;
    private Sensor mSensorRot;
    private float lux = -1000;

    public void init(Context context) {

        mSensorManager = (SensorManager) context.getSystemService(Context.SENSOR_SERVICE);
        mSensorRot = mSensorManager.getDefaultSensor(Sensor.TYPE_LIGHT);

        SensorEventListener mySensorEventListener = new SensorEventListener() {

            @Override
            public void onSensorChanged(SensorEvent event) {
                float sensorData[];

                if(event.sensor.getType()== Sensor.TYPE_LIGHT) {
                    sensorData = event.values.clone();
                    lux = sensorData[0];
                }
            }

            @Override
            public void onAccuracyChanged(Sensor sensor, int accuracy) {}
        };
        mSensorManager.registerListener(mySensorEventListener, mSensorRot, 500);
    }

    public float getLux () {
        return lux;
    }
}
