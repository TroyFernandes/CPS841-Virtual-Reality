using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerRight : MonoBehaviour {

    public Rigidbody balloon;
    SteamVR_TrackedController controller;
    public LineRenderer lineRenderer;
    GameObject indicator;
    GameObject player;

    private Ray ray;
    RaycastHit hit2;

    // Use this for initialization
    void Start() {

        indicator = GameObject.Find("Indicator");
        player = GameObject.Find("[CameraRig]");

        // indicator.GetComponent<MeshRenderer>().enabled = false;


        lineRenderer = GetComponent<LineRenderer>();

        controller = GetComponent<SteamVR_TrackedController>();
        if (controller == null) {
            controller = gameObject.AddComponent<SteamVR_TrackedController>();
        }
        controller.TriggerClicked += new ClickedEventHandler(Fire);
        lineRenderer.enabled = true;

    }

    // Update is called once per frame
    void Update() {
        Debug.DrawRay(transform.position, transform.forward * 10, Color.green);

        ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(transform.position, transform.forward * 10, out hit2)) {
            if (hit2.transform.tag == "ground") {
                indicator.GetComponent<Transform>().position = hit2.point;
                indicator.GetComponent<MeshRenderer>().enabled = true;
            }
            else {
                ;//indicator.GetComponent<MeshRenderer>().enabled = false;
            }
        }



    }

    // Fire when trigger on controller clicks
    void Fire(object sender, ClickedEventArgs e) {
        Debug.Log("Trigger Pressed");
        player.GetComponent<Transform>().position = hit2.point;
    }
}
