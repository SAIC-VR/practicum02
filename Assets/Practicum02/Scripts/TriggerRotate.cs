// SAIC VR practice scripts
// using simple Unity functions to create interactions in VR
// Brenda Lopez
// Use and modify to match your needs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRotate : MonoBehaviour {
	//public  RotateToSwitch = null;
	public GameObject targetToSpin;

	public float speed = 50f;

	public void OnTriggerEnter(Collider other) {
		print ("entered the trigger zone!");
		//RotateToSwitch.transform.Rotate(Vector3.right * Time.deltaTime);
		//targetToSpin.transform.Rotate(Vector3.right * Time.deltaTime);
	}

	public void OnTriggerStay(Collider other){
		targetToSpin.transform.Rotate(Vector3.up * speed * Time.deltaTime);
	}

	public void OnTriggerExit(Collider other) {
		print ("exit the trigger zone!");
		//RotateToSwitch.enabled = true;
	}
}
