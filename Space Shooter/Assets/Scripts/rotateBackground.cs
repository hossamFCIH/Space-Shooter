using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBackground : MonoBehaviour {

    public float rotSpeed = 35.0f;
    void start()
    {

    }
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(x: -1, y: 0, z: 0), rotSpeed * Time.deltaTime,Space.World);
	}
}
