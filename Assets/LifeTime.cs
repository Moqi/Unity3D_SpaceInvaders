using UnityEngine;
using System.Collections;

public class LifeTime : MonoBehaviour {

	public float lifeTime = 10.0f; /* in seconds */

	void Update () {

		lifeTime -= Time.deltaTime;

		if (lifeTime <= 0.0f) {
			Destroy (gameObject);
		} // End of If

	} // End of Method

} // End of Class
