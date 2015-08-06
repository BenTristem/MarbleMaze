using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class ShowVTilt : MonoBehaviour {

	public Slider vSlider;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		vSlider.value = CrossPlatformInputManager.GetAxis ("Vertical");
	}
}
