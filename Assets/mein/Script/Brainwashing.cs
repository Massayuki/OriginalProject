using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brainwashing : MonoBehaviour {
	public GameObject brainwashing;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == "GeneralPublic") {
            Vector3 InsPos = collision.gameObject.transform.position;
            Instantiate (brainwashing, new Vector3(InsPos.x, InsPos.y + 1.5f, InsPos.z), Quaternion.identity);
			Destroy (this.gameObject);
			collision.gameObject.tag = "SatanArmy";
			PartyScore.PartyCount += 1;
		}
	}
}
