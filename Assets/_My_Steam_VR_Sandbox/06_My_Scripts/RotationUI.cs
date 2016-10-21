using UnityEngine;
using System.Collections;

public class RotationUI : MonoBehaviour {
	
	//Update is called once per frame
	void Update () {

		//this will rotate the transform towards the camera so that the camera will always see this UI
		transform.rotation = Camera.main.transform.rotation;

	}

}