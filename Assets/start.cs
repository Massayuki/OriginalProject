/*
 タイトル->ステージ
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.Space)){
            SceneManager.LoadScene("staze");
            downasdown.HP = 10.0f;
            ScoreScript.Count = 0;
            PartyScore.PartyCount = 0;
        }
	}
}
