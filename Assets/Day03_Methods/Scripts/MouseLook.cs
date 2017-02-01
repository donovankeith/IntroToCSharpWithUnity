// MouseLook
// Rotates object based on mouse input.
// Based on a script of the same name from "Unity 5.0 In Action"

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {
	public float sensitivity = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (
			Input.GetAxis("Mouse Y") * sensitivity,
			-Input.GetAxis("Mouse X") * sensitivity,
			0
		));
	}
}
