using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supervisor : MonoBehaviour {

	GameObject canvasExterior;
	Player player;
	string text;
	float time = 0f;
	[SerializeField] private float sesionTime = 10000f;
	[SerializeField] [Range(0f,10000f)] private float MinSecondsBetweenTimes = 60f;
	[SerializeField] [Range(1f,30f)] private float supervisorEnabledTime = 20f;
	private float supervisorEnabledTimeCount = 0f;
	private float[] times;
	private bool supervisorEnabled = false;
	private bool time1End = false;
	private bool time2End = false;
	// Use this for initialization
	void Start () {

		canvasExterior = GameObject.FindGameObjectWithTag ("CanvasExterior");
		canvasExterior.SetActive (false);
		player = GetComponent<Player> ();

		times = new float[2];

		times[0] = Random.Range (1f, sesionTime);

		while(Mathf.Abs (times[1] - times[0]) < MinSecondsBetweenTimes){

			times[1] = Random.Range (0f, sesionTime);
		}

		Debug.Log ("firstTime: " + times[0]);
		Debug.Log ("secondTime: " + times[1]);
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;

		if(supervisorEnabled){

			supervisorEnabledTimeCount += Time.deltaTime;

			player.SetPause (true);
		}

		if(supervisorEnabledTimeCount >= supervisorEnabledTime){

			supervisorEnabledTimeCount = 0f;
			supervisorEnabled = false;
			canvasExterior.SetActive (false);
		}

		if(time >= times[0] && !supervisorEnabled && !time1End){

			time1End = true;
			supervisorEnabled = true;
			canvasExterior.SetActive (true);
		}

		if(time >= times[1] && !supervisorEnabled && !time2End){

			time2End = true;
			supervisorEnabled = true;
			canvasExterior.SetActive (true);
		}

	}
		
}
