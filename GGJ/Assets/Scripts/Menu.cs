using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	public SceneController sceneConntroller;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) {


			RaycastHit hitInfo = new RaycastHit ();
			bool hit = Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo);


			if (hit) {

				string tag = hitInfo.transform.gameObject.tag;
				Debug.Log (tag);

				switch (tag) {

				case "Play":

					sceneConntroller.LoadMain ();
					break;
				
				case "Credits":

					sceneConntroller.LoadCredits();
					break;

				case "Exit":

					sceneConntroller.Exit ();
					break;
				}
			} else {
			
				Debug.Log ("no hit");
			}
		}
	}
}
