using UnityEngine;
using System.Collections;

public class ShootByTouch : MonoBehaviour {

	public Shoot shootScript;

	// Update is called once per frame
	void Update () {
		if (Input.touches[0].phase == TouchPhase.Began) {
				shootScript.shoot ();
		}
	} // End of Method

} // End of Class
