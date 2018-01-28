using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour {

	private HingeJoint2D anchor1, anchor2;
	// Use this for initialization
	void Start () {

		anchor1 = transform.GetChild(0).GetComponent<HingeJoint2D> ();
		
		HingeJoint2D[] hingeJoint2 = new HingeJoint2D[2];
		hingeJoint2 = transform.GetChild(16).GetComponents<HingeJoint2D> ();
		anchor2 = hingeJoint2 [1];

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetAnchor1(Vector2 newAnchor1Coor){

		// Debug.Log ("Anchor1Coor" + newAnchor1Coor);
		anchor1.connectedAnchor = newAnchor1Coor;
	}

	public void SetAnchor2(Vector2 newAnchor2Coor){

		// Debug.Log ("Anchor2Coor" + newAnchor2Coor);
		anchor2.enabled = true;
		anchor2.connectedAnchor = newAnchor2Coor;
	}
		
}
