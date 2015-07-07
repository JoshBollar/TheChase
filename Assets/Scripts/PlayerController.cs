using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 5;
	public float collideDistance = 5;

	// Use this for initialization
	void Start () {
		name = "Player";
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		Vector3 directionVector = new Vector3(0,0,0);
		if (Input.GetKey (KeyCode.W) ){
			// get forwardVector
			// Vector3 directionVector = new Vector3(0, 0, 1);
			// transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Camera.main.transform.forward.z * step); //transform.position + Camera.main.transform.forward * step;
			// transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + step);
			directionVector = Camera.main.transform.forward;
		}
		if (Input.GetKey (KeyCode.A)) {
			directionVector = -Camera.main.transform.right;
			// transform.position = transform.position + Camera.main.transform.forward * step;
			// this.transform.position = new Vector3(this.transform.position.x - step, this.transform.position.y, this.transform.position.z);
		}      
		if (Input.GetKey (KeyCode.S)) {
			directionVector = -Camera.main.transform.forward;
			// transform.position = transform.position + Camera.main.transform.forward * step;
			// this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - step); 
		}

		if (Input.GetKey (KeyCode.D)) {
			directionVector = Camera.main.transform.right;
			// transform.position = transform.position + Camera.main.transform.forward * step;
			// this.transform.position = new Vector3(this.transform.position.x + step, this.transform.position.y, this.transform.position.z);
		}

		if (!(directionVector == new Vector3 (0, 0, 0))) {
			if (!Physics.Raycast (transform.position, directionVector, collideDistance)) {
				transform.position = transform.position + directionVector * step;
			}
		}
			
		
	}
}
