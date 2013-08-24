using UnityEngine;
using System.Collections;

public class GibOnCollide : MonoBehaviour {

	public GameObject[] gibs;

	public float explosionForce = 100.0f;

	public float spawnRadius = 1.0f;

	//
	void OnTriggerEnter (Collider other) {
		if (other.tag != "Enemy") {
			foreach (GameObject gib in gibs) {
				Vector3 position = transform.position + Random.insideUnitSphere * spawnRadius;
				GameObject gibInstance = Instantiate (gib, position, transform.rotation) as GameObject;
				gibInstance.rigidbody.AddExplosionForce (explosionForce, transform.position, spawnRadius);
			}
			Destroy (gameObject);
		}
	} // End of Method

} // End of Class
