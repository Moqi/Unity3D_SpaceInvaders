using UnityEngine;
using System.Collections;

public class GameOverOnCollide : MonoBehaviour {

	//
	void OnTriggerEnter (Collider other) {
		// Enemy touched me! I have to die...
		if (other.tag == "Enemy") {
			GameManager.isGameOver = true;
			Destroy (gameObject);
		}
	} // End of Method

} // End of Class
