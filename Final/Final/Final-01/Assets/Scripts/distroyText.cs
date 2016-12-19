using UnityEngine;
using System.Collections;

public class distroyText : MonoBehaviour {

	public float lifetime=0.1f;

	void Awake(){
		Destroy (gameObject, lifetime);


	
	}
}
