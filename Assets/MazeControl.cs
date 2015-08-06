using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class MazeControl : MonoBehaviour {

	[Range (0.05f, 1f)]
	public float sensitivity;

	public bool smoothing;
	public float smoothTime = 1.0f;

	private Vector3 initialRotation;

	// Use this for initialization
	void Start () {
		initialRotation = transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		float zInput = -CrossPlatformInputManager.GetAxis (("Horizontal")) * 90f * sensitivity;
		float xInput = CrossPlatformInputManager.GetAxis ("Vertical") * 90f * sensitivity;

		transform.localRotation = Quaternion.Euler (new Vector3 (xInput, 0f, zInput));
	}
}
