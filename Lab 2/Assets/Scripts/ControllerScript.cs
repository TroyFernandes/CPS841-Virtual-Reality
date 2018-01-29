using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour {
    private SteamVR_TrackedController device;
	// Use this for initialization
	void Start () {
        Debug.Log("Debugging");
        device = GetComponent<SteamVR_TrackedController>();
        device.TriggerClicked += Trigger;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Debugging");
    }
    void Trigger(object sender, ClickedEventArgs e) {
        Debug.Log("Trigger Pressed");
    }
}
