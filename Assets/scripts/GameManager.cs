using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int score = 0;

	public static int highScore = 0;

	public static float startingSpeed = 3.0f;

	public static float increaseSpeedPerLevel = 2.0f;

	public static float speed = 0.0f;

	public static bool gameOver = false;

	// Use this for initialization
	void Start () {
		speed = startingSpeed;
	}

	// Update is called once per frame
	void Update () {
		if (score > highScore) {
			highScore = score;
		}

		if (gameOver) {
			Application.LoadLevel ("Main Scene");
			gameOver = false;
		}
	} // End of Method

	//
	void OnGUI () {
		GUI.Label (new Rect (0, 0, 100, 20), "Score: " + score.ToString ());
		GUI.Label (new Rect (100, 0, 100, 20), "High Score: " + highScore.ToString ());
		if (gameOver) {
			GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 300, 20), "Game Over!");
		}
	} // End of Method

} // End of Class
