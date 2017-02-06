// MoveXPerFrame.cs
// Demonstrates different ways that you can move an object.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveXPerFrame : MonoBehaviour {

	public float movementPerFrame = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPos = transform.position;
		newPos.x += movementPerFrame;

		transform.position = newPos;
	}
}
