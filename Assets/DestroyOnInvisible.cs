using UnityEngine;
using System.Collections;

public class DestroyOnInvisible : MonoBehaviour {

	//
	void OnBecameInvisible () {
		Destroy (gameObject);
	} // End of Method

} // End of Class
