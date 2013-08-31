using UnityEngine;
using System.Collections;

public class MovementOnKeypress : MonoBehaviour {

	private Vector3 dirAccel = Vector3.zero;

	public float translateMultiply = 5.0f;

	void Update () {
		dirAccel.z = Input.GetAxisRaw ("Horizontal");

		if (dirAccel.sqrMagnitude > 1) {
			dirAccel.Normalize ();
		} // End of If

		transform.Translate (dirAccel * Time.deltaTime * translateMultiply);
	} // End of Method

} // End of Class
