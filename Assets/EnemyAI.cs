using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public float speed = 10.0f;

	public float leftEdgePadding = 0.0f;

	public float rightEdgePadding = 0.0f;

	public float dropDistance = 0.0f;

	private int direction = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = transform.position;
		Vector3 screenPoint = Camera.main.WorldToScreenPoint (newPosition);

		newPosition.x += direction * speed * Time.deltaTime;
		transform.position = newPosition;

		if (screenPoint.x > (Screen.width + rightEdgePadding)) {
//// Nao entendi essa parte...
			float cameraObject2Difference = transform.position.z - Camera.main.transform.position.z;
			Vector3 screenPos = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width, 0, cameraObject2Difference));
//// Nao entendi essa parte...
			direction = -1;
			newPosition = transform.position;
			newPosition.x = screenPos.x;
			newPosition.y -= dropDistance;
			transform.position = newPosition;
		} // End of If
		else if (screenPoint.x < (0 + leftEdgePadding)) {
//// Nao entendi essa parte...
			float cameraObject2Difference = transform.position.z - Camera.main.transform.position.z;
			Vector3 screenPos = Camera.main.ScreenToWorldPoint (new Vector3 (0.0f, 0, cameraObject2Difference));
//// Nao entendi essa parte...
			direction = 1;
			newPosition = transform.position;
			newPosition.x = screenPos.x;
			newPosition.y -= dropDistance;
			transform.position = newPosition;
		} // End of If

	} // End of Method

} // End of Class
