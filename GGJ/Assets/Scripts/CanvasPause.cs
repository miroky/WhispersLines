using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasPause : MonoBehaviour {

	//vars
	Button resumeButton;
	Button menuButton;
	Player player;
	// Use this for initialization
	void Start () {

		resumeButton = GameObject.FindGameObjectWithTag("ResumeButton").GetComponent<Button>();
		resumeButton.onClick.AddListener (ResumeButtonAction);

		menuButton = GameObject.FindGameObjectWithTag("MenuButton").GetComponent<Button> ();
		menuButton.onClick.AddListener (MenuButtonAction);

		player = GameObject.FindGameObjectWithTag ("GameController").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void ResumeButtonAction(){

		Time.timeScale = 1f;
		player.SetPause(false);
		gameObject.SetActive (false);
	}

	private void MenuButtonAction(){

		SceneManager.LoadScene("Menu");
	}
}
