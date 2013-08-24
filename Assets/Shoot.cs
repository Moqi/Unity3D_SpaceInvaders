using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bullet;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {
			Instantiate (bullet, transform.position, transform.rotation);
		}
	} // End of Method

} // End of Class
