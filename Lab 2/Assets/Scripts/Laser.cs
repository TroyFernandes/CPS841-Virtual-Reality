using UnityEngine;

public class Laser : MonoBehaviour
{

    LineRenderer lineRend;
    Vector3 startPos = new Vector3(0, 0, 0);
    Vector3 endPos = new Vector3(0, 0, 10);


    void Start()
    {
        lineRend = GetComponent<LineRenderer>();
    }

    void Update()
    {

        lineRend.SetPosition(0, startPos);
        lineRend.SetPosition(1, endPos);

    }
}
