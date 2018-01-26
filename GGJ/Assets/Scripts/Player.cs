using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	//var
	[SerializeField] private float speed;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1")){

			RaycastHit hitInfo = new RaycastHit ();
			bool hit = Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo);

			if (hit) {
			
				Debug.Log (hitInfo.transform.gameObject.name);
			} else {
			
				Debug.Log ("No hit");
			}

		}

		if(Input.GetAxis("Horizontal") != 0){

			transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime,0f,0f);
		}
	}
}
