﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sensors1;
using System;
using UnityEngine.SceneManagement;

public class TestSensors : MonoBehaviour
{

    public Button play;
    public Dropdown sensorInput;

    // Start is called before the first frame update
    void Start()
    {
        play.onClick.AddListener(callSensorLibrary);
    }

    public void callSensorLibrary()
    {        
        int val = sensorInput.value;
        int sensorType = val + 1;
        Debug.Log("Chosen value from drop down : "+sensorType);
        Sensors1.Sensors sensor = new Sensors1.Sensors();
        SensorController sc = new SensorController();
        sc.setSensorType(sensorType);
        Debug.Log(sensor.chooseSensor(sensorType));
        SceneManager.LoadScene("SensorTest");
    }
}

