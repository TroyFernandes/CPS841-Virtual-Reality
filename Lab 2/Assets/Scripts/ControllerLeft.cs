using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerLeft : MonoBehaviour {
    public Rigidbody balloon;
    public Transform controllerTransform;
    SteamVR_TrackedController controller;
    public List<GameObject> Children;

    // Use this for initialization
    void Start() {
        controller = GetComponent<SteamVR_TrackedController>();
        if (controller == null) {
            controller = gameObject.AddComponent<SteamVR_TrackedController>();
        }
        controller.TriggerClicked += new ClickedEventHandler(createBalloon);
        controller.TriggerUnclicked += new ClickedEventHandler(Release);
    }

    // Update is called once per frame
    void Update() {

    }

    // Fire when trigger on controller clicks
    void createBalloon(object sender, ClickedEventArgs e) {
        Debug.Log("Fired");
        //Instantiate(balloon,transform.position,transform.rotation);
        //GameObject obj = Instantiate(balloon.gameObject,transform.position,transform.rotation);
        var go = Instantiate(balloon.gameObject, transform.position, transform.rotation) as GameObject;
        go.transform.parent = controllerTransform;
        Children.Add(go);

    }

    void Release(object sender, ClickedEventArgs e) {
        
         foreach (Transform child in controllerTransform)
         {
             if (child.tag == "balloon")
             {
                child.GetComponent<ConstantForce>().enabled = true;
                child.GetComponent<Rigidbody>().useGravity = true;
                child.parent = null;
             }
         }
    }

}
