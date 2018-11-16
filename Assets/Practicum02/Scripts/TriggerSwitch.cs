// SAIC VR practice scripts
// using simple Unity functions to create interactions in VR
// Brenda Lopez
// Use and modify to match your needs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSwitch : MonoBehaviour {
	public Light lightToSwitch = null;
	public GameObject objectToSpin = null;
	public Renderer rend;
	public Renderer rendy;
	public Color colorStart = Color.red;
	public Color colorEnd = Color.blue;

	public float speed = 10f;
	public float duration = 1.0f;
//
	void Start(){
		rend = GetComponent <Renderer> ();
		rendy = objectToSpin.GetComponent <Renderer> ();
	}

	void Update(){
		
	}

	public void OnTriggerEnter(Collider other){
		lightToSwitch.enabled = false;
		print ("Just enterd the switch collider!");
	}

	public void OnTriggerStay(Collider other){
		objectToSpin.transform.Rotate (Vector3.forward, speed);
		LinearColorChange ();
	}

	public void OnTriggerExit(Collider other){
		lightToSwitch.enabled = true;
		print ("Just exit the OnTriggerExit collider");
	}

	void LinearColorChange(){
		float myPingPong = Mathf.PingPong (Time.time, duration) / duration;

		rendy.material.color = Color.Lerp (colorStart, colorEnd, myPingPong);
	}
}