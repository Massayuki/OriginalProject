using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotato2 : MonoBehaviour {

	Vector3 mySelf;//自分の初期ベクトルを保存
	Vector3 updateParsent;
	GameObject p;


	// Use this for initialization
	void Start () {
		p = GameObject.Find ("FirstPersonCharacter");
		mySelf = gameObject.transform.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
		updateParsent = p.transform.eulerAngles;
		gameObject.transform.eulerAngles = updateParsent + mySelf;
	}
}
