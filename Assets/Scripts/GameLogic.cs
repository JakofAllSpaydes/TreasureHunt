using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	bool didPlayerWin = false;
	public Transform player;
	public Transform treasure;
	public Transform hint1;
	public Transform hint2;
	public Transform hint3;
	public Transform hint4;
	public Transform hint5;
	public Text textbox;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		if (didPlayerWin == true) {
			
			textbox.text = "Doggo got the bone. All is well in the world";

		}else if ((treasure.position - player.position).magnitude < 3f){
			
			textbox.text = "Press [SPACE] to get BONE!";

			if (Input.GetKeyDown (KeyCode.Space)) {
				didPlayerWin = true;
			}
	}

		if ((hint1.position - player.position).magnitude < 3f) {

			textbox.text = "You are a doggo. Being wet sucks. Go south.";
		
		}

		if ((hint2.position - player.position).magnitude < 3f) {

			textbox.text = "Is that your frisbee? No...it's not. Keep swimming East.";

		}

		if ((hint3.position - player.position).magnitude < 3f) {

			textbox.text = "A Tree! You pee on it. \nYou smell something in the distance. Northwest.";

		}

		if ((hint4.position - player.position).magnitude < 3f) {

			textbox.text = "You play with the red ball. You are satisfied. \nDoggie senses tingle. Northeast.";

		}

		if ((hint5.position - player.position).magnitude < 3f) {

			textbox.text = "Why human angry? Why human in water? Doggo ponders. \n Is that...BONE? GO NORTH!";

		}

}

}