using UnityEngine;

public class Laser : MonoBehaviour
{

    LineRenderer lineRend;
    Vector3 startPos = new Vector3(0, 0, 0);
    Vector3 endPos = new Vector3(0, 0, 10);
    RaycastHit hit;
    public Selectable selectScript;
    

    void Start()
    {
        lineRend = GetComponent<LineRenderer>();
    }

    void Update()
    {

        lineRend.SetPosition(0, startPos);
        lineRend.SetPosition(1, endPos);
        Selectable selectableObj = GetComponent<Selectable>();
        if (Physics.Raycast(transform.position, transform.forward * 10, out hit)) {
            if (hit.transform.tag == "selectable" && selectableObj != null) {
                selectableObj.OutlineEnable();
            }
            else {
                //selectableObj.OutlineDisable();
            }
        }
    }
}
