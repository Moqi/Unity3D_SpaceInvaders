using UnityEngine;
using System.Collections;

public class Android_SpaceShip_Spawners : MonoBehaviour {

	public Transform mainPlayer;

	public Transform sphere;

	public float maxNextTime = 2.0f;

	public float minNextTime = 0.01f;

	private float nextTime = 1.0f;

	private float currentTime = 0.0f;

	void Start () {
		getNextTime ();
	} // End of Method

	void Update () {

		currentTime += Time.deltaTime;

		if (currentTime > nextTime) {
			Vector3 position = Vector3.zero;

			position = transform.position;
			position.x = mainPlayer.transform.position.x;
			Instantiate (sphere, position, transform.rotation);
			getNextTime ();
			currentTime = 0.0f;
		} // End of If

	} // End of Method

	void getNextTime () {
		nextTime = Random.Range (minNextTime, maxNextTime);
	} // End of Method

} // End of Class
