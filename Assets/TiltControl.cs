using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class TiltControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 inputValue;

		inputValue.x = CrossPlatformInputManager.GetAxis ("Vertical");
		inputValue.y = 0f;
		inputValue.z = CrossPlatformInputManager.GetAxis ("Horizontal");

		print (inputValue.x + " , " + inputValue.z);

		transform.eulerAngles = inputValue;
	}
}
