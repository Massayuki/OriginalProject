using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPup : MonoBehaviour {
	public GameObject eating;
	Slider _slider;
	downasdown down;

	// Use this for initialization
	void Start () {
		
		_slider = GameObject.Find ("Slider").GetComponent<Slider> ();
		down = GetComponent<downasdown> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (_slider.value);
		//_slider.value += 5.0f;
	}

	private void OnCollisionEnter(Collision col){
		//Debug.Log ("collider");

		if (col.gameObject.tag == "eat") {
			
			//_slider.value += 5.0f;
			if (downasdown.HP + 5.0f > 10.0f) {
				downasdown.HP = 10.0f;
			} else {
				downasdown.HP += 5.0f;
			}
			Destroy (col.gameObject);
			//Debug.Log ("食べました");
		}
	}
}
