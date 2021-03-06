// Mix Color
// mixes between two colors over time.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixColor : MonoBehaviour {

	public Color start = new Color (0f, 0f, 0f);
	public Color end = new Color(1f, 0f, 0f);
	public float frequency = 1.0f;

	// Returns a blended value between start and end determined by strength percentage `delta`
	// It is assumed that 0 <= delta <= 1, there is no clamping of input or output values.
	float mixFloat (float start, float end, float delta) {
		return start + ((end - start) * delta);
	}

	Color mixColor (Color start, Color end, float delta)
	{
		Color result = new Color ();
		result.r = mixFloat (start.r, end.r, delta);
		result.g = mixFloat (start.g, end.g, delta);
		result.b = mixFloat (start.b, end.b, delta);

		return result;
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// Set the object's color to the combination of the above mix or Red, Green, and Blue
		GetComponent<Renderer> ().material.color = mixColor(start, end, Time.time % frequency);
	}
}
