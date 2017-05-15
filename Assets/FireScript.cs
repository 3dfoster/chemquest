using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class FireScript : MonoBehaviour {

    public GameObject prefab;
    private Vector3 startingPosition;

    public Material inactiveMaterial;
    public Material gazedAtMaterial;

    void Start() {
        //startingPosition = transform.localPosition;
        SetGazedAt(false);
    }

    public void SetGazedAt(bool gazedAt) {
        if (inactiveMaterial != null && gazedAtMaterial != null) {
            GetComponent<Renderer>().material = gazedAt ? gazedAtMaterial : inactiveMaterial;
            return;
        }
    }

    public void Reset() {
        //transform.localPosition = transform.position; // startingPosition;
    }

    public void putOutFire() {
        if (GlobalVariables.isHoldingWater == true) {

            GameObject[] fires = GameObject.FindGameObjectsWithTag("Fire");
                for (int i = 0; i < fires.Length; i++) {
                    Destroy(fires[i]);
                }
            Destroy(GameObject.FindGameObjectWithTag("Water"));
            WaterRise.rise = true;
            }
    }
}
