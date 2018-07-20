/*
 弾の飛ばす方向
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectorposition : MonoBehaviour {
	GameObject start;
	GameObject target;
	Vector3 vel;
	Vector3 vec;
	float lenght;
	// Use this for initialization
	void Start () {
		start = GameObject.Find ("ShotPos");
		target = GameObject.Find ("transformpoint");
	}
	
	// Update is called once per frame
	void Update () {
		vel = target.transform.position - start.transform.position;
		vec = transform.position - start.transform.position;
		lenght = vec.magnitude;
		if (lenght < 40.0f) {
			vel = vel.normalized;
			transform.position += vel;
		} else {
			Destroy (this.gameObject);
			//gameObject.transform.position = start.transform.position;
		}
	}
}
