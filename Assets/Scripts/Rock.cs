using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : ObjectMove {

	[SerializeField] 
	Vector3 topPosition;
	[SerializeField]
	Vector3 bottomPosition;
	[SerializeField]
	float SpeedUp;
	// Use this for initialization
	void Start () {
		StartCoroutine(MoveRock(bottomPosition));
	}

	protected override void Update()
	{
		base.Update();
	}
	IEnumerator MoveRock(Vector3 targuet)
	{
		while (Mathf.Abs((targuet - transform.localPosition).y) > 0.20f)
		{
			Vector3 direction = targuet.y == topPosition.y ? Vector3.up : Vector3.down;
			transform.localPosition += direction * (Time.deltaTime * SpeedUp);
			yield return null;
		}

		Debug.Log("Targuet reached");

		yield return new WaitForSeconds(0.5f);

		Vector3 newTarguet = targuet.y == topPosition.y ? bottomPosition : topPosition;

		StartCoroutine(MoveRock(newTarguet));
	}
}
