using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elementz : MonoBehaviour {

    public GameObject prefab;
    int i = 1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void grow() {

        transform.localScale += new Vector3(0.1F, 0.1F, 0.1F);

    }

    public void outputStuff() {

        Instantiate(prefab, new Vector3((i * 4) + -25.59656F, 0.1475F, 27.42173F), Quaternion.identity);
        if (i < 5) {
            i++;
        }
    }
    public void outputStuff2() {

        Instantiate(prefab, new Vector3((i * 4) + -25.59656F, 2.1475F, 27.42173F), Quaternion.identity);
        if (i < 5) {
            i++;
        }
    }
}
