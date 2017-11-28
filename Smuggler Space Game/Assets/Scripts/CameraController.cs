using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform Target;

	public Vector3 Offset;

	public bool useOffsetValue;
	// Use this for initialization
	void Start () {
		if (!useOffsetValue) {
			Offset = Target.position - transform.position;
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Target.position - Offset;
		transform.LookAt (Target);
	}
}
