using UnityEngine;

public class Target : MonoBehaviour
{
    public Material outlineMaterial;

    public void Remove()
    {
        Destroy(gameObject);
    }


    void Start() {
        gameObject.GetComponent<Renderer>().material = null;

    }

    public void OutlineEnable() {
        gameObject.GetComponent<Renderer>().material = outlineMaterial;

    }
    public void OutlineDisable() {
        gameObject.GetComponent<Renderer>().material = null;
    }

}
