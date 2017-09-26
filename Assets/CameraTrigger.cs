using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour {

	public Transform lookOverride;
	public Transform moveOverride;

	void OnTriggerEnter (Collider activator){

		CameraControllerScript camControl = Camera.main.GetComponent<CameraControllerScript> ();

		if (lookOverride != null) {
			camControl.lookAtTarget = lookOverride;
		}

		if (moveOverride != null) {
			camControl.moveToTarget = moveOverride;
		}

		Destroy (GetComponent<BoxCollider>());
	}

	void OnDrawGizmos (){
		if (lookOverride != null) {
			Gizmos.color = Color.black;
			Gizmos.DrawLine (transform.position, lookOverride.position);
		}

		if (moveOverride != null) {
			Gizmos.color = Color.red;
			Gizmos.DrawLine (transform.position, moveOverride.position);
		}
	}
}
