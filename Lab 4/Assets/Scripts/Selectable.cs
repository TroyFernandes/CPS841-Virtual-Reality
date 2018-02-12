using UnityEngine;

public class Selectable : MonoBehaviour {
    Material[] materials;
    public Material outlineMaterial;
    //public void Remove()
    // {
    //  Destroy(gameObject);
    //}
    void Start() {
        materials = GetComponent<Renderer>().materials;
        gameObject.GetComponent<Renderer>().material = null;

    }

    public void OutlineEnable() {
        gameObject.GetComponent<Renderer>().material = outlineMaterial;

    }
    public void OutlineDisable() {
        gameObject.GetComponent<Renderer>().material = null;
    }
}
