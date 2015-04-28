using UnityEngine;
using System.Collections;

public class BackgroundMusic : MonoBehaviour {
	
	public AudioClip ambient_noise;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void ambient_noisePlay () {
		audio.PlayOneShot (ambient_noise);
	}
	
}
