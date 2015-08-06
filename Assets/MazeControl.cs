using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class MazeControl : MonoBehaviour {

	[Range (0.05f, 1f)]
	public float sensitivity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float xInput = CrossPlatformInputManager.GetAxis (("Horizontal")) * 90f * sensitivity;
		float zInput = CrossPlatformInputManager.GetAxis ("Vertical") * 90f * sensitivity;
		transform.localRotation = Quaternion.Euler (new Vector3 (xInput, 0f, zInput));
	}
}
