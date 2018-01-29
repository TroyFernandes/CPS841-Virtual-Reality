using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerLeft : MonoBehaviour {
    //private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_Controller.Device device;
    private SteamVR_TrackedObject trackedObj;
    private SteamVR_TrackedController controller;

    public Rigidbody balloon;

	// Use this for initialization
	void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        controller = GetComponent<SteamVR_TrackedController>();
        controller.PadClicked += Controller_PadClicked;
	}
	
	// Update is called once per frame
	void Update () {
        device = SteamVR_Controller.Input((int)trackedObj.index);
        if (device.GetHairTrigger()) {
            Instantiate(balloon);
        }
    }
    private void Controller_PadClicked(object sender, ClickedEventArgs e) {
        if (device.GetAxis().x != 0 || device.GetAxis().y != 0) {
            Debug.Log(device.GetAxis().x + " " + device.GetAxis().y);
        }
        if (device.GetHairTrigger()) {
            Instantiate(balloon);
        }
}
}
