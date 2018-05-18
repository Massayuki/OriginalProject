using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.Rotate (Vector3.right * 30.0f, Space.World);
		this.transform.position += new Vector3(3,5,7);
	}
}
