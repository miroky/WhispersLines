using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supervisor : MonoBehaviour {

	GameObject canvasExterior;
	GameObject supervisorImage;
	Player player;
	string text;
	float time = 0f;
	[SerializeField] private float sessionTime = 10000f;
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
		supervisorImage = GameObject.FindGameObjectWithTag ("SupervisorImage");
		canvasExterior.SetActive (false);
		player = GetComponent<Player> ();

		times = new float[2];

		times[0] = Random.Range (1f, sessionTime);
		times[1] = Random.Range (1f, sessionTime);

		while(Mathf.Abs (times[1] - times[0]) < MinSecondsBetweenTimes){

			times[1] = Random.Range (1f, sessionTime);
		}
			
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;

		if(supervisorEnabled){

			supervisorEnabledTimeCount += Time.deltaTime;
		}

		//el supervisor sale
		if(supervisorEnabledTimeCount >= supervisorEnabledTime){

			supervisorEnabledTimeCount = 0f;
			supervisorEnabled = false;
			canvasExterior.SetActive (false);
			player.SetPause (false);
			Debug.Log ("supervisor pause FALSE");
		}

		if(time >= times[0] && !supervisorEnabled && !time1End){

			time1End = true;
			supervisorEnabled = true;
			canvasExterior.SetActive (true);
		}

		//el supervisor entra
		if(time >= times[1] && !supervisorEnabled && !time2End){

			time2End = true;
			supervisorEnabled = true;
			canvasExterior.SetActive (true);
			player.SetPause (true);
			Debug.Log ("supervisor pause TRUE");
		}

	}
		
}
