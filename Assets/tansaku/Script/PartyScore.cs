using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartyScore : MonoBehaviour {

	public Text ScoreLabel;
	public static int PartyCount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ScoreLabel.text = PartyCount.ToString ();
	}
}
