using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public Rigidbody balloon;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        //Valve.VR.OpenVR.System.ResetSeatedZeroPose();
        //Valve.VR.OpenVR.Compositor.SetTrackingSpace(
        //Valve.VR.ETrackingUniverseOrigin.TrackingUniverseSeated);
        if (Input.GetKeyDown("space")) {

            Instantiate(balloon);
        }
    }
}
