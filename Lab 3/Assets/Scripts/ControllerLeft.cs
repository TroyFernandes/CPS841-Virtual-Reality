using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerLeft : MonoBehaviour {
    public Vector3 velocity;
    public Transform controllerTransform;
    SteamVR_TrackedController controller;
    public List<GameObject> Children;

    [SerializeField]
    private GameObject obj;
    private FixedJoint fixedJoint;

    // Use this for initialization
    void Start() {

        controller = GetComponent<SteamVR_TrackedController>();
        obj = GetComponent<GameObject>();
        fixedJoint = GetComponent<FixedJoint>();


        if (controller == null) {
            controller = gameObject.AddComponent<SteamVR_TrackedController>();
        }
        controller.TriggerClicked += new ClickedEventHandler(PickUpObj);
        controller.TriggerUnclicked += new ClickedEventHandler(DropObj);
    }

    // Update is called once per frame
    void Update() {
        //isKinematic is disabled
        velocity = controller.GetComponent<Rigidbody>().velocity;
    }


    void OnTriggerStay(Collider other) {
        if (other.CompareTag("pickup")) {
            obj = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other) {
        obj = null;
    }

    void PickUpObj(object sender, ClickedEventArgs e) {
        if (obj != null) {
            fixedJoint.connectedBody = obj.GetComponent<Rigidbody>();

        }
        else {
            fixedJoint.connectedBody = null;
        }
    }

    void DropObj(object sender, ClickedEventArgs e) {
        Debug.Log("Drop Object");
        //velocity = controller.GetComponent<Rigidbody>().velocity;

       // Debug.Log(velocity.ToString());
        if (fixedJoint.connectedBody != null) {
            fixedJoint.connectedBody = null;

        }
    }


}
