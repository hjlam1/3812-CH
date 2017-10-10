﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunInBackground : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Application.runInBackground = true;
    }
	
	// Update is called once per frame
	void Update () {
        SteamVR_Controller.Input((int)1).TriggerHapticPulse(1500);
	}
}
