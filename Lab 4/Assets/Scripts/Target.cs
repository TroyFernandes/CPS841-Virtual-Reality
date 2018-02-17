using UnityEngine;

public class Target : MonoBehaviour
{
    public Material outlineMaterial;
    public Vector3 size;
    public float rotate;


    public void Remove()
    {
        Destroy(gameObject);
    }


    void Start() {
        gameObject.GetComponent<Renderer>().material = null;
        size = gameObject.GetComponent<Transform>().transform.localScale;
        rotate = gameObject.GetComponent<Transform>().transform.rotation.y;
    }

    void Update()
    {

    }

    public void OutlineEnable() {
        gameObject.GetComponent<Renderer>().material = outlineMaterial;

    }
    public void OutlineDisable() {
        gameObject.GetComponent<Renderer>().material = null;
    }
    public void increaseSize(int sizingFactor)
    {
        size = size * sizingFactor;
        gameObject.GetComponent<Transform>().transform.localScale = size;
    }
    public void rotateObjectY(int degrees)
    {
        transform.Rotate(0, degrees, 0);
    }

}
