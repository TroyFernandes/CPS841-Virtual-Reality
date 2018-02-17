using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
    public bool color;
    ControllerRight controllerRight;
	// Use this for initialization
	void Start () {
        controllerRight = new ControllerRight();
        color = false;
	}
	
	// Update is called once per frame
	void Update () {
        //if (color) {
        //    setColor();
        //    color = false;
        //}
	}

    public void setColor(GameObject gameObj) {
        if (controllerRight.getGameObject() != null) {
            gameObj.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    public void setBoolean(bool changeColor) {
        color = changeColor;
    }

}
