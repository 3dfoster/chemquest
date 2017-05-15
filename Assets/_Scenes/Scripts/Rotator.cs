using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(13,30,45) * Time.deltaTime);
		//transform.localScale += new Vector3(0.5F, 0,0) * Time.deltaTime;
	}
}
