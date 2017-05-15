using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Collider))]
public class Water : MonoBehaviour {
    private Vector3 startingPosition;
    public Material inactiveMaterial;
    public Material gazedAtMaterial;

    void Start() {
        startingPosition = transform.localPosition;
        SetGazedAt(false);
        GlobalVariables.isHoldingAir = false;
    }

    public void SetGazedAt(bool gazedAt) {
        if (inactiveMaterial != null && gazedAtMaterial != null) {
            GetComponent<Renderer>().material = gazedAt ? gazedAtMaterial : inactiveMaterial;
            return;
        }
    }

    public void Reset() {
        transform.localPosition = transform.position; // startingPosition;
    }

    public void holdAir() { // Hold thing

        transform.parent = Camera.main.transform;
        transform.localPosition = new Vector3(2.5f, 0, 4.5f);
        GlobalVariables.isHoldingAir = true;
    }
}
