using UnityEngine;
using System.Collections;

public class BulletDestroyedOnCollide : MonoBehaviour {

	//
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Enemy") {
				Destroy (gameObject);
		} // End of If
	} // End of Method

} // End of Class
