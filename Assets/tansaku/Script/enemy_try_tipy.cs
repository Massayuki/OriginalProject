using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_try_tipy : MonoBehaviour {
	GameObject player;
	public Transform target;


	// Use this for initialization
	void Start () {
		//GameObject player = GameObject.Find ("FPSController (1)");
		player.GetComponent<Transform> ();
		target = player.transform;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
