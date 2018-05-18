using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour {
	public Transform target;
	NavMeshAgent agent;
	public GameObject exploion;

	int enemyHP =2;

	// Use this for initialization
	void Start () {
		GameObject player = GameObject.Find ("FPSController (1)");
		player.GetComponent<Transform> ();
		target = player.transform;
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
	    //playerを追いかける
		agent.SetDestination (target.position);
	}
	//ダメージを受けた時の処理
	void Damage(){
		//enemyHP -= 1;//HPを１減らす
		//Debug.Log( enemyHP);
		//if (enemyHP ==0){
			//HPが０になったら
			//ScoreScript.EnemyCount += 1;
			//Destroy (this.gameObject);//自分を消す
		//}
}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "FPSController"){
			other.gameObject.SendMessage ("PlayerDamage");
		}
}
}