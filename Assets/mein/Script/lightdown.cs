using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightdown : MonoBehaviour {
	public Light light1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		light1 = this.GetComponent<Light> ();
		light1.intensity -= 0.01f;
	}
}
