using UnityEngine;
using System.Collections;

public class ChangeScoreOnCollide : MonoBehaviour {

	public int pointValue = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		GameManager.score += pointValue;
	} // End of Class

} // End of Class
