using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour {

	public GameObject spawnObject;

	public int spawnAreaWidth;

	public int spawnAreaHeight;

	public Vector2 numberOfEnemies;

	// Use this for initialization
	void Start () {
		for (int x = 0; x < numberOfEnemies.x; x++) {
			for (int y = 0; y < numberOfEnemies.y; y++) {
				Vector3 spawnPosition = transform.position;
				spawnPosition.x += x * spawnAreaWidth / numberOfEnemies.x;
				spawnPosition.y += y * spawnAreaHeight / numberOfEnemies.y;
				GameObject newObject = Instantiate (spawnObject, spawnPosition, transform.rotation) as GameObject;
				newObject.transform.parent = gameObject.transform; // Add the created Game Object inside to my parent (Enemy Manager Game Object)
			} // End of For
		} // End of For
	} // End of Method

	void Update () {
		if (transform.childCount == 0) { // Number of child objects added in Start method
			GameManager.speed += GameManager.increaseSpeedPerLevel;
			Start ();
		} // End of If
	} // End of Method

} // End of Class
