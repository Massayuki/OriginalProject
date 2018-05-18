using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class downasdown : MonoBehaviour {
	Slider _slider;
	public static float HP = 10.0f;
	// Use this for initialization
	void Start () {
		_slider = GameObject.Find ("Slider").GetComponent<Slider> ();

	}
	// Update is called once per frame
	void Update () {
		HP -= 0.001f;
		_slider.value = HP;
	}
}
