using UnityEngine;
using System.Collections;

public class Android_SpaceShip_Sphere_Explosion : MonoBehaviour {

	void OnCollisionEnter (Collision collision) {
		//if (collision.relativeVelocity.magnitude > 2)
		//	audio.Play ();
		if (collision.gameObject.name == "Terrain") {
			Destroy (gameObject);
		}
		else if (collision.gameObject.tag != "Enemy") {
			Android_SpaceShip_Spawners_Score script = GameObject.Find ("Sphere Spawners").GetComponent < Android_SpaceShip_Spawners_Score> ();
			script.increaseScore ();
			Destroy (gameObject);
		} // End of If

	} // End of Method

} // End of Class
