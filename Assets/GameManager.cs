using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject[] BlastBalls;
	public Text DisplayText;

	// Use this for initialization
	void Start () {
		for(int counter=0; counter<20; counter++){
			BlastBalls [counter].GetComponent<ConstantForce> ().force = new Vector3 (0f, 0f, 0f);
			}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			DisplayText.text = " ";
			for(int counter=0; counter<20; counter++){
				BlastBalls [counter].GetComponent<ConstantForce> ().force = new Vector3 (50f, 1f, 0f);
			}
			CameraControllerScript camControl = Camera.main.GetComponent<CameraControllerScript> ();
			camControl.lookAtTarget = BlastBalls [19].GetComponent<Transform> ();
		}
	}
}
