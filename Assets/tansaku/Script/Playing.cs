using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playing : MonoBehaviour {
	//public Light LightObject;
	public GameObject gitudan;
	public GameObject gameb;
	public GameObject GamePlayer;
	public GameObject at;
	public GameObject ber;
	private PlayPoint Ppoint;
	// Use this for initialization
	void Start () {
		Ppoint = ber.GetComponent<PlayPoint> ();
	}
	
	// Update is called once per frame
	void Update () {
		  if (Input.GetMouseButtonDown (0)) {
			  // 銃弾を生成
				if(Ppoint.Point >= 0.2f){
			  GameObject.Instantiate (gitudan, gameb.transform.position, Quaternion.identity);//親欲しい
			  //gitudan.transform.parent = GamePlayer.transform;
				Ppoint.Point -= 0.2f;
				}
		  }
		if (Input.GetMouseButtonDown (1)) {
			if (Ppoint.Point >= 0.2f) {
				GameObject.Instantiate (at, gameb.transform.position, Quaternion.identity);
				Ppoint.Point -= 0.2f;
			}
		}
	  }
	}
	

