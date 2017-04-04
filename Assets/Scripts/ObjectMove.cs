using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour {

	[SerializeField]
	private float speed = 1.0f;
	private float ResetPosition = -19.88f;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * (speed *Time.deltaTime));
		if (transform.localPosition.x <= ResetPosition)
		{
			Vector3 newPos = new Vector3(85.0f, transform.position.y, transform.position.z);
			transform.position = newPos;
		}
	}
}
