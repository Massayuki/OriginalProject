using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clear : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if(ScoreScript.Count > 1){
            Debug.Log("clear");
            SceneManager.LoadScene("Clear");
        }
	}
}
