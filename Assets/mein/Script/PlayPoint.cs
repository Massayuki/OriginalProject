using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPoint : MonoBehaviour {
	public Slider srider;
	public float Point = 1;
	// Use this for initialization
	void Start () {
		srider = GameObject.Find("Slider (1)").GetComponent<Slider>();

	}

	// Update is called once per frame
	void Update () {
		Point += 0.001f;
		if (Point > 1) {
			Point = 1;
		}
		if (Point <= 0) {
			Point = 0;
		}

		srider.value = Point;
	}
}
