﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

public float moveSpeed;
//public Rigidbody theRB;
public float jumpForce;
public CharacterController controller;
private Vector3 moveDirection;
	// Use this for initialization
	void Start () {
		//theRB = GetComponent<Rigidbody>();
		controller = GetComponent<CharacterController>();

	}

	// Update is called once per frame
	void Update () {
		/*
		theRB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y,Input.GetAxis("Vertical")*moveSpeed);

		if(Input.GetButtonDown("Jump"))
		{
			theRB.velocity = new Vector3(theRB.velocity.x,jumpForce,theRB.velocity.z);
		}
		*/
		moveDirection = new Vector3(Input.GetAxis("Horizontal")* moveSpeed, 0f, Input.GetAxis("Vertical")*moveSpeed);

		if(Input.GetButtonDown("Jump"))
		{
			moveDirection.y = jumpforce;
		}

		moveDirection.y = moveDirection.y +Physics.gravity.y;
		controller.Move(moveDirection * Time.deltaTime)
	}
}
