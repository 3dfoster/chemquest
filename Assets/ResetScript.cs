using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class ResetScript : MonoBehaviour {

    public Material inactiveMaterial;
    public Material gazedAtMaterial;

    void Start() {
        SetGazedAt(false);
    }

    public void SetGazedAt(bool gazedAt) {
        if (inactiveMaterial != null && gazedAtMaterial != null) {
            GetComponent<Renderer>().material = gazedAt ? gazedAtMaterial : inactiveMaterial;
            return;
        }
    }
    
    public void destroyElements() {
        GameObject[] hydrogens = GameObject.FindGameObjectsWithTag("Hydrogen");
        GameObject[] oxygens = GameObject.FindGameObjectsWithTag("Oxygen");
        for (int i = 0; i < hydrogens.Length; i++) {
            Destroy(hydrogens[i]);
        }
        for (int i = 0; i < oxygens.Length; i++) {
            Destroy(oxygens[i]);
        }
        Destroy(GameObject.FindGameObjectWithTag("Water"));
        Destroy(GameObject.FindGameObjectWithTag("Air"));
    }
}
