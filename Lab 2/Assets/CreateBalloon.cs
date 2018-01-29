using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBalloon : MonoBehaviour {
    public Rigidbody balloon;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space")) {

            Instantiate(balloon);
        }
    }
}
