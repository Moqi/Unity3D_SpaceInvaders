using UnityEngine;
using System.Collections;

public class GibOnCollide : MonoBehaviour {

	public GameObject[] physicsGibs;

	public GameObject[] staticGibs;

	public float explosionForce = 100.0f;

	public float spawnRadius = 1.0f;

	//
	void OnTriggerEnter (Collider other) {
		if (other.tag != "Enemy") {
			foreach (GameObject gib in physicsGibs) {
				Vector3 position = transform.position + Random.insideUnitSphere * spawnRadius;
				GameObject gibInstance = Instantiate (gib, position, transform.rotation) as GameObject;
				gibInstance.rigidbody.AddExplosionForce (explosionForce, transform.position, spawnRadius);
			}
			foreach (GameObject gib in staticGibs) {
				/*GameObject gibInstance =*/ Instantiate (gib, transform.position, transform.rotation) /*as GameObject*/;
			}
			Destroy (gameObject);
		}
	} // End of Method

} // End of Class
