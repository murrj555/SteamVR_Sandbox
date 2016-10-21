using UnityEngine;
using System.Collections;

public class InWorldCanvasScaler: MonoBehaviour {

	public float pixelsPerUnit = 25f;

	public void OnValidate()
	{
		// Scales the World Canvas UI, there is a bug, so this fixes it. 
		transform.localScale = new Vector3(1 / pixelsPerUnit, 1 / pixelsPerUnit, 1);

	}


}