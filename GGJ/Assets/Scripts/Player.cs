using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	//var
	[SerializeField] private float speed = 10f;
	float movement;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		//left click
		if(Input.GetButtonDown("Fire1")){

			RaycastHit hitInfo = new RaycastHit ();
			bool hit = Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo);

			if (hit) {
			
				Debug.Log (hitInfo.transform.gameObject.name);
			} else {
			
				Debug.Log ("No hit");
			}

		}

		//lateral camera movement
		if (Input.GetAxis ("Horizontal") < 0) {

			movement = -speed * Time.deltaTime;
		}
		if(Input.GetAxis ("Horizontal") > 0){

			movement = speed * Time.deltaTime;
		}
			Debug.Log (movement);

		if(transform.position.x + movement >= 0f && transform.position.x + movement <= 6.55f){

			transform.Translate(movement,0f,0f);
		}
	
	}

}
