// CollisionHighlight.cs
// Draws a ray when objects collide.
// Inspired by: https://docs.unity3d.com/ScriptReference/Debug.DrawRay.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHighlight : MonoBehaviour {

	public float duration = Mathf.Infinity;

	// Use this for initialization
	void Start () {
		
	}
	
	void drawCollision(Collision collision, float length, Color color, float duration) {
		// Draws a line wherever there is a collision.
		// To see the ray, you need to be in the Scene view.
		foreach (ContactPoint contact in collision.contacts) {
			Debug.DrawRay(contact.point, contact.normal * length, color, duration);
		}
	}


	public Color enterCollisionColor = Color.red;
	public float enterLength = 1.0f;

	void OnCollisionEnter(Collision collision) {
		drawCollision(collision, enterLength, enterCollisionColor, duration);
	}


	public Color stayCollisionColor = Color.blue;
	public float stayLength = 0.5f;

	void OnCollisionStay(Collision collision) {
		drawCollision(collision, stayLength, stayCollisionColor, duration);
	}


	public Color exitCollisionColor = Color.green;
	public float exitLength = 1.0f;

	void OnCollisionExit(Collision collision) {
		Debug.Log ("Exit!");
		drawCollision(collision, exitLength, exitCollisionColor, duration);
	}
}
