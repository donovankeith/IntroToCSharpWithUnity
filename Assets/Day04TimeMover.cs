using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day04TimeMover : MonoBehaviour {
	public Vector3 offset;
	public Vector3 direction;
	public float frequency = 2f;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		float scale = Mathf.Abs( Mathf.Sin (Time.time * frequency));
		transform.position = offset + (direction * scale);
	}
}
