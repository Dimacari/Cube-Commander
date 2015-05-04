using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {
	public Camera camera;
	public Camera camera2;
	public Camera camera3;

	// Use this for initialization
	void Start () {
		camera.enabled = true;
		camera2.enabled = false;
		camera3.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Alpha0)) {
			Time.timeScale = 1;
			camera.enabled = camera.enabled;
			camera2.enabled = camera2.enabled;
			camera3.enabled = camera3.enabled;
		}
	if (Input.GetKeyUp (KeyCode.Alpha1)) {
			Time.timeScale = 0;
			camera.enabled = !camera.enabled;
			camera2.enabled = !camera2.enabled;
			camera3.enabled = camera3.enabled;
		}
		if (Input.GetKeyUp (KeyCode.Alpha2)) {
			Time.timeScale = 0;
			camera.enabled = !camera.enabled;
			camera2.enabled = camera2.enabled;
			camera3.enabled = !camera3.enabled;
		}
	}
}
