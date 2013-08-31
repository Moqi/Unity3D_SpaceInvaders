using UnityEngine;
using System.Collections;

public class Android_SpaceShip_Spawners_Score : MonoBehaviour {

	public GUIText textScore;

	private int score;

	void Start () {
		score = 0;
	} // End of Method

	public void increaseScore () {
		score ++;
		textScore.text = "Score: " + score;
	} // End of Method

} // End of Class
