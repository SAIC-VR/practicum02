// SAIC VR practice scripts
// using simple Unity functions to create interactions in VR
// Brenda Lopez
// Use and modify to match your needs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToTarget : MonoBehaviour {

	public GameObject destination;
	private Vector3 teleportTarget;

	void Start () {
		// start by loading a destination where we want to teleport
		teleportTarget = destination.GetComponent<Transform>().position;
	}

	void Update () {
	}

	private void OnTriggerEnter(Collider other)
	{
		// to make sure it teleports only when the user enters
		// we can add a Player tag to the user and conpare with other collisions
		//if (other.CompareTag("Player")){
			Debug.Log ("Player entered the trigger");
			other.transform.position = teleportTarget;
		//}
	}
}
