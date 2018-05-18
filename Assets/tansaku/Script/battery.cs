using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battery : MonoBehaviour {
	public Light LightObject;
	//public GameObject gitudan;
	// Use this for initialization
	void Start () {
		LightObject.GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetMouseButtonDown (0)) {
			//GameObject.Instantiate (gitudan, this.transform.position, Quaternion.identity);
		//}
	}
	private void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "battery") {
			LightObject.intensity += 15.0f;
			Destroy (col.gameObject);
			Debug.Log ("電池を取り替えました");
		}
	}
}
