using UnityEngine;
using System.Collections;

public class FIshPlay : MonoBehaviour {

	public AudioClip FishAudio;
	public GameObject Farm;

	void Start(){
		GetComponent<AudioSource> ().playOnAwake = false;
		GetComponent<AudioSource> ().clip = FishAudio;
	}

	void OnTriggerEnter(Collider Farm){  //Plays Sound Whenever collision detected

		GetComponent<AudioSource> ().Play ();
			Debug.Log ("fish!");
	}
	
	
	
	
	}





