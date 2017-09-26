using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerScript : MonoBehaviour {

	public Transform lookAtTarget;
	public Transform moveToTarget;

	// Update is called once per frame
	void Update () {
		if (lookAtTarget != null) {
			transform.LookAt (lookAtTarget.position);
		}

		if (moveToTarget != null) {
			Vector3 moveDirection = moveToTarget.position - transform.position;
			if (moveDirection.magnitude > 1f) {
				moveDirection = moveDirection / moveDirection.magnitude;

			}

			transform.position += moveDirection * Time.deltaTime* 10f;

		}
	}
}
