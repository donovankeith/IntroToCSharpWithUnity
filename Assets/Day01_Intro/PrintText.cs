using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// `Debug` is an object that allows you to access Unity's console.
		// you can try `Console.WriteLine()` but you won't get the result you're expecting.
		// this is because Unity is not a Command Line application.
		// Source: http://answers.unity3d.com/questions/1023544/why-doesnt-consolewriteline-work-in-monodevelop-si.html
		Debug.Log ("This prints at the start of the game. Check the Console for the output.");

		// You may be asking, why not just use print()?
		// Well, because it only works inside of MonoBehavior classes, and you may want to
		// print outside of those. It's easier to learn one thing than two.
	}
	
	// Update is called once per frame
	void Update () {
		// This will show up in the Console.
		Debug.Log ("This is called every frame.");
		
	}
}
