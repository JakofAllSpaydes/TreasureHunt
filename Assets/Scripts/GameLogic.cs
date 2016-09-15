using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	bool didPlayerWin = false;
	public Transform player;
	public Transform treasure;
	public Text textbox;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		if (didPlayerWin == true) {
			
			textbox.text = "You got the treasure!";

		}else if ((treasure.position - player.position).magnitude < 3f){
			
			textbox.text = "Press [SPACE] to get treasure!";

			if (Input.GetKeyDown (KeyCode.Space)) {
				didPlayerWin = true;
			}
	}
}

}