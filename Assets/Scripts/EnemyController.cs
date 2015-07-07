using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public GameObject target;
	public GameObject gameControllerObject;
	public float speed = 5;
	// Use this for initialization
	void Start () {

	}

	void onCollision (Collision collision) {
		if(collision.collider.name.Equals("Player")){
			Debug.Log ("Player loses!!!");
			gameControllerObject.GetComponent<GameController>().endGame();
		}
	}

	// Update is called once per frame
	void Update() {
		// enemy moveTowards
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
	}
}
