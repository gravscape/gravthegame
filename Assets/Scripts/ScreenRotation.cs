using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRotation : MonoBehaviour {

	public float smooth = 1f;
	private Quaternion targetRotation;
	private int angle = 0;
	public Rigidbody rig;
	public float grav = 9.81f;

	// Use this for initialization
	void Start () {
		targetRotation = transform.rotation;
	}

	enum Richting{
		L, R
	}

	void Rotate(Richting richting){
		switch (richting) {
		case Richting.L:
			angle++;
			targetRotation *=  Quaternion.AngleAxis(90, Vector3.back);
			rig.velocity = Vector3.zero;
			float radAngle = (90 * angle) * (Mathf.PI / 180);
			Physics.gravity = new Vector3 (-Mathf.Round(Mathf.Sin (radAngle)) * grav,Mathf.Round(-Mathf.Cos (radAngle)) * grav,0);
			break;
		case Richting.R:
			break;
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) { 
			Rotate (Richting.L);
		} 
		transform.rotation= Quaternion.Lerp (transform.rotation, targetRotation , 10 * smooth * Time.deltaTime);
	}
}
