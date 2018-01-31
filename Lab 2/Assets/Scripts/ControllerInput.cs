using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour {
    public SteamVR_TrackedObject mTrackedObject = null;
    public SteamVR_Controller.Device mDevice;
    public Rigidbody balloon;
    public Transform controllerEnd;


    public int Yvalue = 0;
	// Use this for initialization
	void Start () {
        mTrackedObject = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () {
        mDevice = SteamVR_Controller.Input((int)mTrackedObject.index);

        if (mDevice.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)) {
            print("Trigger Down");
            Debug.Log("Trigger Down");

            Rigidbody balloonInstance;

            //Vector3 position = controllerEnd.position;
            //position.y = position.y + Yvalue;

            balloonInstance = Instantiate(balloon, controllerEnd.position, controllerEnd.rotation) as Rigidbody;
            balloonInstance.AddForce(controllerEnd.up * 1);
            Instantiate(balloon);

        }
        if (mDevice.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger)) {
            print("Trigger up");
            Debug.Log("Trigger up");
            Instantiate(balloon);

        }
    }
}
