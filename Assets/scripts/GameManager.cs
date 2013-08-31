using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private enum GAME_STATES { MAIN_MENU_STATE, GAME_STATE, GAME_OVER };

	public static int score = 0;

	public static int highScore = 0;

	public static float startingSpeed = 3.0f;

	public static float increaseSpeedPerLevel = 2.0f;

	public static float speed = 0.0f;

	public static bool isGameOver = false;

	private static GAME_STATES currentState = GAME_STATES.MAIN_MENU_STATE;

	public GUISkin guiSkin;

	// Use this for initialization
	void Start () {
		// Check which Platform this game would run and set games properties...
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) {
			// TODO Change it to a iOS/Android GameManager
			Screen.orientation = ScreenOrientation.Landscape;
			Screen.sleepTimeout = SleepTimeout.NeverSleep;
		} // End of Method

		speed = startingSpeed;
	}

	// Update is called once per frame
	void Update () {
		switch (currentState) {
			case GAME_STATES.MAIN_MENU_STATE: {
					// If Escape Key was pressed, then Quit!
					if (Input.GetKey (KeyCode.Escape)) {
						Application.Quit ();
					} // End of If
				}
				break;
		case GAME_STATES.GAME_STATE: {
				// User pressed BACK/ESCAPE key, User has quit and reset score. 
				if (Input.GetKey (KeyCode.Escape)) {
					score = 0;
					currentState = GAME_STATES.MAIN_MENU_STATE;
					Application.LoadLevel ("Main Menu");
				}

				if (score > highScore) {
					highScore = score;
				}

				if (isGameOver) {
					currentState = GAME_STATES.GAME_OVER;
				}
			}
			break;
		case GAME_STATES.GAME_OVER: {
				StartCoroutine (changeToMainMenu ());
			}
			break;
		default: {

			}
			break;
		} // End of Switch
	} // End of Method

	// Esperar X segudos, para mostrar mensagem de "Game Over", antes de mudar de cena.
	IEnumerator changeToMainMenu () {
		yield return new WaitForSeconds (3 /* seconds */);
		Debug.Log ("Changed state " + isGameOver);
		isGameOver = false;
		score = 0;
		currentState = GAME_STATES.MAIN_MENU_STATE;
		Application.LoadLevel ("Main Menu");
	} // End of Method

	//
	void OnGUI () {
		GUI.skin = guiSkin;

		switch (currentState) {
			case GAME_STATES.MAIN_MENU_STATE: {
					float SCREEN_WIDTH = Screen.width;
					float SCREEN_HEIGHT = Screen.height;
					float CENTER_SCREEN_X = SCREEN_WIDTH / 2.0f;
					float CENTER_SCREEN_Y = SCREEN_HEIGHT / 2.0f;


					// Make a group on the center of the screen
					float MENU_WIDTH = 300.0f;
					float MENU_HEIGHT = 300.0f;
					float CENTER_MENU_X = MENU_WIDTH / 2.0f;
					float CENTER_MENU_Y = MENU_HEIGHT / 2.0f;
					Rect posCenter = new Rect (CENTER_SCREEN_X - CENTER_MENU_X, CENTER_SCREEN_Y - CENTER_MENU_Y, MENU_WIDTH, MENU_HEIGHT);
					GUI.BeginGroup (posCenter);

						// All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.
						// We'll make a box so you can see where the group is on-screen.
						GUI.Box (new Rect (0, 0, MENU_WIDTH, MENU_HEIGHT), "Group is here");

						// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
						float BUTTON_WIDTH = 250.0f;
						float BUTTON_HEIGHT = 50.0f;
						Rect buttonPos = new Rect (25, 50, BUTTON_WIDTH, BUTTON_HEIGHT);

						//if (GUI.Button (new Rect (25, 40, 250, 50), "Main Menu")) {
						//	currentState = GAME_STATES.MAIN_MENU_STATE;
						//	Application.LoadLevel ("Main Menu");
						//}

						// Make the second button.
						if (GUI.Button (buttonPos, "Game")) {
							Debug.Log ("LOADING GAME...");
							currentState = GAME_STATES.GAME_STATE;
							Application.LoadLevel ("Game");
						}

					// End the group we started above. This is very important to remember!
					GUI.EndGroup ();
				}
				break;
			case GAME_STATES.GAME_STATE: {
					GUI.BeginGroup (new Rect (0, 0, 300, 120));
						GUI.Label (new Rect (0, 0, 300, 40), "Score: " + score.ToString ());
						GUI.Label (new Rect (0, 50, 300, 40), "High Score: " + highScore.ToString ());
					GUI.EndGroup ();
				}
				break;
			case GAME_STATES.GAME_OVER: {
				// Make a group on the center of the screen
				if (isGameOver) {
					int SCREEN_WIDTH = Screen.width;
					int SCREEN_HEIGHT = Screen.height;
					int CENTER_SCREEN_X = SCREEN_WIDTH / 2;
					int CENTER_SCREEN_Y = SCREEN_HEIGHT / 2;
					int MENU_WIDTH = 200;
					int MENU_HEIGHT = 150;
					int CENTER_MENU_X = MENU_WIDTH / 2;
					int CENTER_MENU_Y = MENU_HEIGHT / 2;
					Rect messageCenter = new Rect (CENTER_SCREEN_X - CENTER_MENU_X, CENTER_SCREEN_Y - CENTER_MENU_Y, MENU_WIDTH, MENU_HEIGHT);
					GUI.Label (messageCenter, "Game Over");
				}
			}
			break;

			default: {

				}
				break;
		} // End of Switch
	} // End of Method


} // End of Class
