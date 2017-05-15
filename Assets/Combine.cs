using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class Combine : MonoBehaviour {

    public GameObject prefab;
    public GameObject prefab2;

    int j = 1;
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

    public void combineElements() {
        GameObject[] hydrogens = GameObject.FindGameObjectsWithTag("Hydrogen");
        GameObject[] oxygens = GameObject.FindGameObjectsWithTag("Oxygen");

        if (hydrogens.Length == 2 && oxygens.Length == 1) {

            for (int i = 0; i < hydrogens.Length; i++) {
                Destroy(hydrogens[i]);
            }
            for (int i = 0; i < oxygens.Length; i++) {
                Destroy(oxygens[i]);
            }

            Instantiate(prefab, new Vector3(-12.8f, -1f, 24f), Quaternion.identity);

            //transform.parent = Camera.main.transform;
            //transform.localPosition = new Vector3(0.5f, 0, 1);
        }
        else if (hydrogens.Length == 0 && oxygens.Length == 2) {

            for (int i = 0; i < hydrogens.Length; i++) {
                Destroy(hydrogens[i]);
            }
            for (int i = 0; i < oxygens.Length; i++) {
                Destroy(oxygens[i]);
            }

            Instantiate(prefab2, new Vector3(-26f, -1f, -11f), Quaternion.identity);

            //transform.parent = Camera.main.transform;
            //transform.localPosition = new Vector3(0.5f, 0, 1);
        }
    }
}
