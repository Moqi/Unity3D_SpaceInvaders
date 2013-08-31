using UnityEngine;
using System.Collections;

public class MovementOnAccelerometer : MonoBehaviour {

	private Vector3 dirAccel = Vector3.zero;

	public float translateMultiply = 5.0f;

	//
	void Update () {
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) {

			dirAccel.z = Input.acceleration.x;

			if (dirAccel.sqrMagnitude > 1) {
				dirAccel.Normalize ();
			} // End of If

			Vector3 newPosition = transform.position;
			Vector3 screenPoint = Camera.main.WorldToScreenPoint (newPosition);

			if (screenPoint.x > 0 && screenPoint.x < Screen.width) {
				newPosition.x += dirAccel.z * Time.deltaTime * translateMultiply;
				Vector3 checkScreenPoint = Camera.main.WorldToScreenPoint (newPosition);
				if (checkScreenPoint.x > 10 && checkScreenPoint.x < Screen.width - 10)
					transform.position = newPosition;

			} // End of If

			//transform.Translate (dirAccel * Time.deltaTime * translateMultiply);

		} // End of If
	} // End of Method


} // End of Class
