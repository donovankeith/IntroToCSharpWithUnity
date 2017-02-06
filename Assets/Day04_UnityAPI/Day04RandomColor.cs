using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day04RandomColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			gameObject.GetComponent<Renderer> ().material.color = Random.ColorHSV ();
		}
	}
}
