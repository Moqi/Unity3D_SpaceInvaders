using UnityEngine;
using System.Collections;

public class DestroyAfterPlayingAudio : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (!audio.isPlaying) {
			Destroy (gameObject);
		}
	} // End of Method

} // End of Class
