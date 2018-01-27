using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	//var
	[SerializeField] private float speed = 10f;
	float movement;
	GameObject mainCamera;
	GameObject CanvasPause;
	// Use this for initialization
	void Start () {
		
		mainCamera = GameObject.FindGameObjectWithTag ("MainCamera");
		CanvasPause = GameObject.FindGameObjectWithTag ("CanvasPause");
	}
	
	// Update is called once per frame
	void Update () {

		//left click
		if(Input.GetButtonDown("Fire1")){

			RaycastHit hitInfo = new RaycastHit ();
			bool hit = Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo);

			if (hit) {

				hitInfo.transform.gameObject.GetComponent<Cell>().CallFromPlayer();

			} else {
			
				Debug.Log ("No hit");
			}

		}

		//right click
		if(Input.GetButtonDown("Fire2")){

			RaycastHit hitInfo = new RaycastHit ();
			bool hit = Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo);

			if (hit) {

				hitInfo.transform.gameObject.GetComponent<Cell>().CallFromPlayerS();

			} else {

				Debug.Log ("No hit special");
			}

		}

		//lateral camera movement
		if (Input.GetAxis ("Horizontal") < 0) {

			movement = -speed * Time.deltaTime;
		}
		if(Input.GetAxis ("Horizontal") > 0){

			movement = speed * Time.deltaTime;
		}

		if(mainCamera.transform.position.x + movement >= 0f && mainCamera.transform.position.x + movement <= 6.55f){

			mainCamera.transform.Translate(movement,0f,0f);
		}

		//Pausa
		if(Input.GetButtonDown("Cancel")){

			if (CanvasPause.activeSelf) {

				CanvasPause.SetActive (false);
				Time.timeScale = 1f;

			} else {
			
				Time.timeScale = 0f;
				CanvasPause.SetActive (true);
			}

		}
	}
}
