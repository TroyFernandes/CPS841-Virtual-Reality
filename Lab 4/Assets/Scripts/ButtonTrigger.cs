using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject selectedObject;

    private ControllerRight controllerRight;
    private Vector3 scale;
    // Use this for initialization
    void Start()
    {
        controllerRight = new ControllerRight();
        selectedObject = controllerRight.getGameObject();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Button")
        {
            if (selectedObject != null)
            {
                scale = selectedObject.GetComponent<Transform>().localScale;
                scale.x += 1f;
                selectedObject.GetComponent<Transform>().localScale = scale;
            }
        }
    }
}
