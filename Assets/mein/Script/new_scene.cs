using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class new_scene : MonoBehaviour {

	public GameObject target;
	float length;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		length=((target.transform.position.x-this.transform.position.x)*(target.transform.position.x-this.transform.position.x)
			+(target.transform.position.y-this.transform.position.y)*(target.transform.position.y-this.transform.position.y)
			+(target.transform.position.z-this.transform.position.z)*(target.transform.position.z-this.transform.position.z));
			
		//Debug.Log (length);
		length = Mathf.Sqrt(length);

		if (length < 3) {
			SceneManager.LoadScene ("Hea");
		}
	}
}
