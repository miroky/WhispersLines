using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	//var
	[SerializeField] private float speed = 10f;
	private float movement;
	private GameObject mainCamera;
	private GameObject CanvasPause;
	private bool pause = false;
	// Use this for initialization
	void Start () {
		
		mainCamera = GameObject.FindGameObjectWithTag ("MainCamera");
		CanvasPause = GameObject.FindGameObjectWithTag ("CanvasPause");
		CanvasPause.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		//left click
		if(Input.GetButtonDown("Fire1") && !pause){

			RaycastHit hitInfo = new RaycastHit ();
			bool hit = Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo);

			if (hit) {

				string tag = hitInfo.transform.gameObject.tag;
				switch (tag) {

				case "Book":

					hitInfo.transform.gameObject.GetComponent<Book> ().Action();
					break;

				case "Drawer":

					hitInfo.transform.gameObject.GetComponent<Drawer> ().Action();
					break;

				default:
					hitInfo.transform.gameObject.GetComponent<Cell>().CallCable();
					break;
				}

			} else {
			
				Debug.Log ("No hit");
			}

		}

		//right click
		if(Input.GetButtonDown("Fire2") && !pause){

			RaycastHit hitInfo = new RaycastHit ();
			bool hit = Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo);

			if (hit) {

				hitInfo.transform.gameObject.GetComponent<Cell>().CallSpecialCable();

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
				pause = false;

			} else {
			
				pause = true;
				Time.timeScale = 0f;
				CanvasPause.SetActive (true);
			}

		}
	}

	public void SetPause (bool newPause){ pause = newPause;}
}
