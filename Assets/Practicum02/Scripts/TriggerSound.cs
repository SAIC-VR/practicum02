// SAIC VR practice scripts
// using simple Unity functions to create interactions in VR
// Brenda Lopez
// Use and modify to match your needsusing UnityEngine;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(AudioSource))]

public class triggerSound : MonoBehaviour {
	private AudioSource audio;
	public AudioClip clip;

	void Awake(){
		audio = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider other){
		//This will play without any testing
		audio.Play();

		// This will play only if the player collides with the trigger
		// add Player tag  in order for this to work 

		// if (other.tag == "Player"){
		// 	audio.Play ();
		// 	Debug.Log("trigger entered & played sound: "+clip);
		// }
	}
}
