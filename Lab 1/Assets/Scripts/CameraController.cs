using UnityEngine;

public class CameraController : MonoBehaviour
{


    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;


    }

    //void FixedUpdate() {
    //    transform.position = player.transform.position;
    //    transform.rotation = Quaternion.Euler(0f, player.transform.rotation.y, 0f);
    //}
}
