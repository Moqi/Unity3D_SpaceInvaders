using UnityEngine;
using System.Collections;

public class BulletDestroyedOnCollide : MonoBehaviour {

	//
	public GameObject[] objectsCanBeDestroyed;

	//
	void OnTriggerEnter (Collider other) {
		foreach (GameObject current in objectsCanBeDestroyed) {
			if (other.tag != current.tag) {
				Destroy (gameObject);
			} // End of If
		} // End of ForWach
	} // End of Method

} // End of Class
