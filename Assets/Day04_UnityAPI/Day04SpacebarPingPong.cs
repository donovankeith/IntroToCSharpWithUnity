using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day04SpacebarPingPong : MonoBehaviour {

	public float movementPerFrame = 0.1f;

	float xDirection;

	// Use this for initialization
	void Start () {
		xDirection = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			xDirection = xDirection * -1.0f;
		}

		Vector3 newPosition = transform.position;
		float movement = xDirection * movementPerFrame;
		newPosition.x += movement;

		transform.position = newPosition;
	}
}
