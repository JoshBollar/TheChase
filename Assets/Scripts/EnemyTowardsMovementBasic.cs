using UnityEngine;
using System.Collections;

public class EnemyMoveTowardsBasic : MonoBehaviour {
	public GameObject target;
	public float speed = 5;
	// Use this for initialization
	void Start () {

	}

	void onCollision (Collision collision) {
	}
	// Update is called once per frame
	void Update() {
		// enemy moveTowards
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
	}
}
