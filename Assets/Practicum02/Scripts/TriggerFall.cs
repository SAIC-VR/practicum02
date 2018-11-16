// SAIC VR practice scripts
// using simple Unity functions to create interactions in VR
// Brenda Lopez
// Use and modify to match your needs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFall : MonoBehaviour {

	public GameObject targetToFall;

	public void OnTriggerEnter(Collider other) {
		print ("entered the trigger zone!");
		targetToFall.GetComponent<Rigidbody> ().useGravity = true;
	}

	public void OnTriggerExit(Collider other) {
		print ("exit the trigger zone!");
		//RotateToSwitch.enabled = true;
	}
}
