using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bann : MonoBehaviour {


	public GameObject parent,ShotPos;
	public Vector3 Rot;
	public GameObject gun;
	void Start () {
		//player = GameObject.Find ("FPSController (1)");
		//if (player != null) {
			//Debug.Log ("test Object");}
		//playerがどれだけ回転しているか
		parent = GameObject.Find("FPSController (1)");
		ShotPos = GameObject.Find ("ShotPos");
		Rot = parent.transform.localEulerAngles;
		//Debug.Log (Rot);
		transform.Rotate (Rot);
	}
	
	// Update is called once per frame
	void Update () {
	}


    void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == "Enemy") {
			Destroy (collision.gameObject);
			//GameObject.Instantiate ( this.transform.position, Quaternion.identity);
			Destroy (this.gameObject);
		}
		if (collision.gameObject.tag == "feeld") {
			Destroy (this.gameObject);
		}

	}
}
