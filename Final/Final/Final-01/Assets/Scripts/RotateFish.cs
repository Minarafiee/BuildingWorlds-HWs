using UnityEngine;
using System.Collections;

// COMPUTER SCIENCE TERM TO GOOGLE IF YOU WANT TO KNOW MORE: "Model View Controller" or MVC

public class RotateFish : MonoBehaviour {

	public GameObject Fish;



	// FixedUpdate is where PHYSICS happens
	void FixedUpdate () {
		// hold down SPACE to add force
//		if ( Input.GetKey( KeyCode.Space ) ) {
//			Fish.GetComponent<Rigidbody>()
//				.AddForce( Fish.transform.forward * 10f );
//		}

		if ( Input.GetKeyDown(KeyCode.A) ) {
			// GetComponent<Transform>()... is like saying "transform..."
			Fish.GetComponent<Transform>().Rotate( 0f, -5f, 0f );
		}
		Debug.Log ("Fish1!");
//		if ( Input.GetKey(KeyCode.Space ) ) {
//			Fish.transform.Rotate( 0f, 5f, 0f );
//		}
//		Debug.Log ("Fish2");
	}
}