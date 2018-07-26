using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraController : MonoBehaviour {
	public GameObject target;
	float desiredDistance = 4f;

	float pitch = 0f;
	float pitchMin = -40f;
	float pitchMax = 60f;
	float yaw = 0f;
	float roll = 0f;

	float sensitivity = 5f;
	// Update is called once per frame
	void Update () {
		transform.position = target.transform.position - desiredDistance * transform.forward + Vector3.up * 3.5f;
		pitch -= sensitivity * Input.GetAxis ("Mouse Y");
		yaw += sensitivity * Input.GetAxis ("Mouse X");

		pitch = Mathf.Clamp (pitch, pitchMin, pitchMax);

		transform.localEulerAngles = new Vector3 (pitch, yaw, roll);
	}
}
