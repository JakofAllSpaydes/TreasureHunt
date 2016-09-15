using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			
			//move object, frame independent
			transform.position += new Vector3 (0, 0, 7) * Time.deltaTime;

			//rotate object to face the way its moving
			//transform.eulerAngles = new Vector3 (0, 0, 0); 
		}

		if (Input.GetKey (KeyCode.S)) {
			
			//move object, frame independent
			transform.position += new Vector3 (0, 0, -7) * Time.deltaTime;

		}

		if (Input.GetKey (KeyCode.A)) {

			//move object, frame independent
			transform.position += new Vector3 (-7, 0, 0) * Time.deltaTime;

		}

		if (Input.GetKey (KeyCode.D)) {

			//move object, frame independent
			transform.position += new Vector3 (7, 0, 0) * Time.deltaTime;

		}

		Camera.main.transform.position = transform.position + new Vector3 (0, 0, 0); //(0, 4, -3

	}
}
