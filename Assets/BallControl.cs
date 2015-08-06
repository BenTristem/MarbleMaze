using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class BallControl : MonoBehaviour {

	public float jumpSpeed;

	private Rigidbody rigidBody;
	private bool jumping = false;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButtonDown ("Jump") && !jumping) {
			rigidBody.velocity += new Vector3 (0, jumpSpeed, 0);
			jumping = true;
			Invoke ("CancelJump", 0.5f);
		}
	}

	void CancelJump () {
		jumping = false;
	}
}
