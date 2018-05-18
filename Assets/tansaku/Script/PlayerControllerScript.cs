using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour {


	public Camera camera;
	public AudioSource gunSound;
	int playerHP = 10;
	public GameObject MuzzleFlush;
	public GameObject firepoint;
	public GameObject burret;
	public Vector3 speed = new Vector3(0.1f,0,0);
	// Use this for initialization

	void Start () {
		Screen.lockCursor = true;
		if (playerHP == 3) {
			Debug.Log ("重症");
		}
	}
	
	// Update is called once per frame
	void Update () {
		//左クリックを押したら
		if (Input.GetMouseButtonDown (0)) {
			Shot ();
			//gunSound.Play ();

			Instantiate (MuzzleFlush, firepoint.transform.position, firepoint.transform.rotation);

		}
		if(Input.GetKey(KeyCode.A)){
			transform.position += speed;
		}
	}

	void PlayerDamage(){
		playerHP -= 1;
		Debug.Log ("残りの体力は"+playerHP);
	}

	void Shot () {
		int distance = 20;
		Vector3 center = new Vector3 (Screen.width/2,Screen.height/2,0);
		Ray ray = camera.ScreenPointToRay (center);
		RaycastHit hitInfo;
			//もしRayが何かぶつかったら
		if (Physics.Raycast (ray, out hitInfo, distance)) {
			//ぶつかった物体がEnemyというタグだったら
			if (hitInfo.collider.tag == "Enemy") {
				//その物体にDamageを実行しろというメッセージを送る
				hitInfo.collider.SendMessage ("Damage");
			}
		}
	}

}