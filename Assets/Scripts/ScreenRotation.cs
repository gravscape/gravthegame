using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			float yRotation = 90.0f;
			transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotation, transform.eulerAngles.z);
		}
	}
}
