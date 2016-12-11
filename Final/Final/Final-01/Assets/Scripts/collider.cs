﻿using UnityEngine;
using System.Collections;

public class collider : MonoBehaviour {
	public GameObject walkingPerson;
	// Use this for initialization
	void Start () {
		walkingPerson.GetComponent<Animator>().SetBool ("StraightWalk", false);

	}
	
	// Update is called once per frame
	void OnTriggerExit (Collider other) {
		other.transform.parent.GetComponent<Animator>().SetBool("StraightWalk", true);
	}





	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if(hit.collider.tag == "Edge")
		{
			GetComponent<MeshRenderer>().enabled = false;
		}
	}


}