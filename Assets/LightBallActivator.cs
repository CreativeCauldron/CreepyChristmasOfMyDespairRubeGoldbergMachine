using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightBallActivator : MonoBehaviour {
	
	public GameObject[] LightBalls;
	public Material Glow;
	public Text DisplayText;

	void OnTriggerEnter (Collider activatr){
		for (int counter=0; counter<15; counter++){
			LightBalls [counter].GetComponent<MeshRenderer> ().material = Glow;
		}
		DisplayText.text = "Wasn't that fun!";
	}
}
