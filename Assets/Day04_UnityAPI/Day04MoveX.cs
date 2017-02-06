using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day04MoveX : MonoBehaviour {

	public Vector3 movementPerFrame = new Vector3 (1.0f, 0f, 0f);

	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (0.0f, 2.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + movementPerFrame;
	}
}
