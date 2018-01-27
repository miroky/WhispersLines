using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour {

	private HingeJoint2D anchor1;
	private HingeJoint2D anchor2;
	// Use this for initialization
	void Start () {

		anchor1 = transform.GetChild(0).GetComponent<HingeJoint2D> ();
		
		HingeJoint2D[] script = new HingeJoint2D[2];
		script = transform.GetChild(16).GetComponents<HingeJoint2D> ();
		anchor2 = script [1];

		Debug.Log (anchor1.anchor);
		Debug.Log (anchor2.anchor);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetAnchor1(Vector2 newAnchor1Coor){

		anchor1.anchor = newAnchor1Coor;
	}

	public void SetAnchor2(Vector2 newAnchor2Coor){

		anchor2.anchor = newAnchor2Coor;
	}
}
