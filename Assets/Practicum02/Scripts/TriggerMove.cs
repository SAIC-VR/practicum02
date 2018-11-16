// SAIC VR practice scripts
// using simple Unity functions to create interactions in VR
// Brenda Lopez
// Use and modify to match your needs
using UnityEngine;
using System.Collections;

public class TriggerMove : MonoBehaviour {
	public GameObject objectToMove = null;
	public float turnSpeed = 2.0f;
	public float moveSpeed = 1.0f;

	private void OnTriggerStay(Collider other) {
		//Rotate the object on the up axis when inside the trigger
		objectToMove.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
		//objectToMove.transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);

	}

	private void OnTriggerEnter(Collider other) {
		//Move the object up 
		// objectToMove.transform.Translate (Vector3.up * moveSpeed * Time.deltaTime, Space.Self);
		objectToMove.transform.position = new Vector3(Mathf.PingPong(Time.time, turnSpeed), transform.position.y, transform.position.z);
		print ("Hi I enter the trigger of: " + objectToMove);

	}

	private void OnTriggerExit(Collider other) {
		// Move the object back to the original postion
		objectToMove.transform.Translate (-Vector3.up * moveSpeed * Time.deltaTime, Space.Self);

	}
}
