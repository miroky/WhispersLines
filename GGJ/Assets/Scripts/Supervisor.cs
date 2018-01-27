using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supervisor : MonoBehaviour {

	GameObject canvasExterior;
	string text;
	float time = 0f;
	[SerializeField] float sesionTime = 10000f;
	[SerializeField] float secondsBetweenTimes = 60f;
	[SerializeField] float supervisorEnabledTime = 20f;
	float supervisorEnabledTimeCount = 0f;
	float firstTime = 0f;
	float secondTime = 0f;
	bool supervisorEnabled = false;
	// Use this for initialization
	void Start () {

		canvasExterior = GameObject.FindGameObjectWithTag ("CanvasExterior");
		canvasExterior.SetActive (false);

		firstTime = Random.Range (0f, sesionTime);

		Debug.Log ("firstTime: " + firstTime);

		while(secondTime < firstTime + secondsBetweenTimes || secondTime < firstTime - secondsBetweenTimes){

			secondTime = Random.Range (0f, sesionTime);
		}


		Debug.Log ("secondTime: " + secondTime);
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;

		Debug.Log (time);
		if(supervisorEnabled){

			supervisorEnabledTimeCount += Time.deltaTime;
		}

		if(supervisorEnabledTimeCount >= supervisorEnabledTime){

			supervisorEnabledTimeCount = 0f;
			supervisorEnabled = false;
			canvasExterior.SetActive (false);
		}

		if((time >= firstTime || time >= secondTime) && !supervisorEnabled){

			supervisorEnabled = true;
			canvasExterior.SetActive (true);
		}

	}
		
}
