using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRise : MonoBehaviour {
    public static bool rise;
    public GameObject prefab;
    int counter = 0;
    // Use this for initialization
    void Start() {
        rise = false;
    }

    // Update is called once per frame
    void Update() {
        if (rise) {
            if (counter < 500) {
                transform.position += new Vector3(0, 0.1F, 0);
                counter++;
            }
            if (counter >= 500) {
                if (GlobalVariables.isHoldingAir == true) {
                    Instantiate(prefab, new Vector3(-25.59656F, 2.1475F, 27.42173F), Quaternion.identity);
                }
                else print("You lose :(");
            }
        }
    }
}