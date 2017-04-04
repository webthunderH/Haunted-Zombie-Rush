using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Animator anim;
	private Rigidbody rigidBody;
	private bool jump = false;
	[SerializeField] private float jumpForce;
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
		rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
		{
			anim.Play("Jump");
			rigidBody.useGravity = true;
			jump = true;
		}
	}
	void FixedUpdate()
	{
		if (jump)
		{
			rigidBody.velocity = new Vector2(0, 0);
			rigidBody.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
			jump = false;
		}
	}
}
