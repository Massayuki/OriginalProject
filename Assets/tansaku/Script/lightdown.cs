using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightdown : MonoBehaviour {
	public Light light;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		light = this.GetComponent<Light> ();
		light.intensity -= 0.01f;
	}
}
