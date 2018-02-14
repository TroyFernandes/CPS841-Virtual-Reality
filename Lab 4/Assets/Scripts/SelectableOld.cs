using UnityEngine;

public class SelectableOld : MonoBehaviour {
    Material[] materials;
    public Material outlineMaterial;

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
