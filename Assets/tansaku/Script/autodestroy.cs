﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autodestroy : MonoBehaviour {
	public float destroyTime = 0.1f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, destroyTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
