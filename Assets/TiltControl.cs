using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class TiltControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		print (CrossPlatformInputManager.GetAxis ("Vertical")) ;
	}
}
