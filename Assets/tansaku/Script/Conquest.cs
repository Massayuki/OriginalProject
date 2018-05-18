using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conquest : MonoBehaviour {
	public GameObject Expload;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == "builting") {
			Instantiate (Expload, transform.position, Quaternion.identity);
			Destroy (this.gameObject);
			collision.gameObject.tag = "Obsolete";
			//Destroy (collision.gameObject);
			ScoreScript.Count += 1;
		}
	}
}
