using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bullet;

	public bool autoShot = true;

	public float delayToShot = 0.5f;

	private float sumDelayToShot = 0.0f;

	// Update is called once per frame
	void Update () {
		if (autoShot) {
			sumDelayToShot += Time.deltaTime;
			if (sumDelayToShot > delayToShot) {
				sumDelayToShot = 0.0f;
				Instantiate (bullet, transform.position, transform.rotation);
			}
		}
		else if (Input.GetKeyDown (KeyCode.Z)) {
			Instantiate (bullet, transform.position, transform.rotation);
		}
	} // End of Method

} // End of Class
