/*
 敵のこと
 */
using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour {
	public Transform target;
	NavMeshAgent agent;
    public GameObject player;
    private Vector3 Startps;
    private downasdown dad;
    bool isGameover = false;


    private void Awake()
    {
        player = GameObject.Find("FPSController (1)");
        player.GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();
        dad = player.GetComponent<downasdown>();
    }

    void Start () {
		target = player.transform;
        Startps = this.transform.position;
	}
	
	
	void Update () {
	    //playerを追いかける
		agent.SetDestination (target.position);

        if(downasdown.HP <= 0){
            this.transform.position = Startps;
        }

	}

    void OnCollisionEnter(Collision other){
        if (other.gameObject.tag == "Player"){
            downasdown.HP -= 1;
		}
    }
 }