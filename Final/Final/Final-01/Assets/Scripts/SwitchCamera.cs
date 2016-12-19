using UnityEngine;
using System.Collections;

public class SwitchCamera : MonoBehaviour {
	public GameObject Text;
	public Camera Camera;
	public Camera MainCamera;

	// Use this for initialization
	void Start () {
		Camera.enabled = true;
		MainCamera.enabled = false;
		Text.SetActive (false);


	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.C)) {
			Text.SetActive (true);
			Camera.enabled = !Camera.enabled;
			MainCamera.enabled = !MainCamera.enabled;

		}
	}
}