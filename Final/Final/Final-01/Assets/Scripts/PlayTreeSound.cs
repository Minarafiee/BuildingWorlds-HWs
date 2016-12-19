using UnityEngine;
using System.Collections;

public class PlayTreeSound : MonoBehaviour {

	public AudioSource SoundTree;





	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown(KeyCode.A))
	if(Input.GetMouseButtonDown(1))
			SoundTree.Play ();

	}
}
