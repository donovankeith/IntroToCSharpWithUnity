using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	public Vector3 velocity = new Vector3(1f, 0f, 0f);
	private Vector3 startPos;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = startPos;
		pos += Time.time * velocity;

		transform.position = pos;
	}
}
