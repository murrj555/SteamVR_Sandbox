using UnityEngine;
using System.Collections;

public class VisibleRangeUI : MonoBehaviour {
	
	CanvasGroup canvasGroup;
	public float visibleDistance = 5f;

	// Use this for initialization
	void Start () {
		canvasGroup = this.GetComponent<CanvasGroup>();
	}

	// Update is called once per frame
	void Update () {
		float distance = (this.transform.position).magnitude;
		float alpha = visibleDistance - distance;

		canvasGroup.alpha = Mathf.Clamp(alpha, 0, 1);
	}
}