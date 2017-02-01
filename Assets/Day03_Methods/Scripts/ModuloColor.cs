// Modulo Color
// Pulses R, G, B in a loop that repeats every 4 seconds.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuloColor : MonoBehaviour {

	public float rFrequency = 1.0f;
	public float gFrequency = 2.0f;
	public float bFrequency = 4.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// Calculate Red/Green/Blue compenent of final color
		float r = (Time.time % rFrequency) / rFrequency;
		float g = (Time.time % gFrequency) / gFrequency;
		float b = (Time.time % bFrequency) / bFrequency;

		// Set the object's color to the combination of the above mix or Red, Green, and Blue
		GetComponent<Renderer> ().material.color = new Color (r, g, b);
	}
}
