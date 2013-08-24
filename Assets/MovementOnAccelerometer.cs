using UnityEngine;
using System.Collections;

public class MovementOnAccelerometer : MonoBehaviour {

	private Vector3 dirAccel = Vector3.zero;

	public float translateMultiply = 5.0f;

	int dir = 1;

	//
	void Start () {
		Screen.orientation = ScreenOrientation.AutoRotation;
	} // End of Method

	//
	void Update () {
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) {

			// If Escape Key was pressed, then Quit!
			if (Input.GetKey (KeyCode.Escape)) {
				Application.Quit ();
			} // End of If

			dirAccel.z = Input.acceleration.x;

			if (dirAccel.sqrMagnitude > 1) {
				dirAccel.Normalize ();
			} // End of If

			transform.Translate (dirAccel * Time.deltaTime * translateMultiply);

		} // End of If
	} // End of Method


} // End of Class
