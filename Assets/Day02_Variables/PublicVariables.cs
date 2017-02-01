// Public Variables.cs
// A quick introduction to how to add variables of various types to your objects.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicVariables : MonoBehaviour {
	// Public
	// These will show up in the Inspector Tab for any object they're attached to.
	public int myInteger;
	public float myFloat;
	public double myDouble;
	public string myString;
	public int[] myIntArray = {3, 5, 7, 11, 13, 15};
	public string[] myStringArray = { "Dogs", "Cats", "Birds", "Fish" };
	public int[,] myMultiArray = { { 1, 2 }, { 2, 4 }, { 8, 16 } };  // Not supported by Unity Editor
	public GameObject myGameObject;

	// Private
	// These can be accessed by the methods of the class, but they can't be edited by the user.
	int myPrivateInteger;
	float myPrivateFloat;
	double myPrivateDouble;
	string myPrivateString;
	int[] myPrivateIntArray = {3, 5, 7, 11, 13, 15};
	string[] myPrivateStringArray = { "Dogs", "Cats", "Birds", "Fish" };
	GameObject myPrivateGameObject;

    // Serialized Private
    // These are still private, but can be edited by the user.
    // Why? http://answers.unity3d.com/questions/213393/private-vs-nonserialized.html
    [SerializeField]
    int myVisiblePrivateInteger;

	// Use this for initialization
	void Start () {
		// Initialize defaults for User
		myInteger = 20;
		myFloat = 3.14f;  // Note the `f` after the number. This indicates this is a Float, which has a lower precision than a double.
		myDouble = 7.0 / 3.0;
		myString = "The quick brown fox jumped over the lazy dog.";

		// Initialize defaults for class.
		myPrivateInteger = 37;
		myPrivateFloat = 2.0f;
		myPrivateDouble = 3.1 / 7.6;
		myPrivateString = "This is a super private string.";
		myPrivateStringArray [3] = "Some other animal";

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
