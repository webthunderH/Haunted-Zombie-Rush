using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour {

	[SerializeField] float speed = 1.0f;
	[SerializeField] float ResetPosition = -19.88f;
	[SerializeField] float StartingPostion = 85.0f;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	protected virtual void Update () {
		transform.Translate(Vector3.right * (speed *Time.deltaTime));
		if (transform.localPosition.x >= ResetPosition)
		{
			Vector3 newPos = new Vector3(StartingPostion, transform.position.y, transform.position.z);
			transform.position = newPos;
		}
	}
}
