using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public float timeAmount = 60.0f;
	// Use this for initialization
	void Start () {
		
	}

	public void endGame() {
		Application.Quit ();
	}
	// Update is called once per frame
	void Update () {
		timeAmount -= Time.deltaTime;
		if (timeAmount <= 0.0f) {
			Debug.Log ("Game ended, player wins!!!");
			endGame ();
		}
	}
}
