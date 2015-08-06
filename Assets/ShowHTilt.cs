using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class ShowHTilt : MonoBehaviour {

	public Slider hSlider;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		hSlider.value = CrossPlatformInputManager.GetAxis ("Horizontal");
	}
}
