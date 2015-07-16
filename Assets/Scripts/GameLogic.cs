using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	public Transform player;
	public Text youWin;
	public Text hint;

	// Use this for initialization
	void Start () {
		youWin.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && 
			Vector3.Distance(player.position, transform.position) < 5)
		{
			youWin.enabled = true;
		}
		if (player.position.x < -50f)
		{
			hint.text = "Psst! You're going the wrong way, head east!";
		}
		if (player.position.z < -50f)
		{
			hint.text = "Ummm you should probably head north NOT south ya dummy";
		}

		if (player.position.x > 330f)
		{
			hint.text = "You're too far east! Back it up just a little bit";
		}
		else if (player.position.z > 320f)
		{
			hint.text = "You're too far north! Back it up just a little bit";
		}
		else if (player.position.x > 50f && player.position.z > 50f)
		{
			hint.text = "You're on the right track! Keep it up!";
		}

		if (player.position.x < 50f && player.position.x > -50f &&
			player.position.z < 50f && player.position.z > -50f)
		{
			hint.text = "Currently in starting area.\nYou're looking for a sphere. When you see it, give it a little love tap and press [SPACE]! Some hints to start you off: Press [SHIFT] to go fast and follow the rocks.";
		}
	}
}
