﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerRight : MonoBehaviour {

    SteamVR_TrackedController controller;
    public LineRenderer lineRenderer;
    public GameObject selectedObject;
    ChangeColor changeColor;
    // Use this for initialization
    void Start() {
        changeColor = new ChangeColor();
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

        //Debug.DrawRay(transform.position, transform.forward * 10, Color.green);

    }

    // Fire when trigger on controller clicks
    void Fire(object sender, ClickedEventArgs e) {
        Debug.Log("Fired");
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward * 10, out hit))
        {
            selectedObject = null;
            Debug.Log("hit" + hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            ChangeColor changeColor = hit.transform.GetComponent<ChangeColor>();
            if (target != null)
            {
                target.OutlineEnable();
                selectedObject = target.gameObject;
            }
            if (changeColor != null) {
                changeColor.setColor(selectedObject);
            }

        }
    }

    public GameObject getGameObject() {
        return selectedObject;
    }

}
