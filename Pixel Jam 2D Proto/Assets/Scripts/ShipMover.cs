using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMover : MonoBehaviour
{
	[SerializeField] private float speed;

	void Update ()
	{
		Vector3 movement = new Vector3 (-1,0,0);
		transform.position -= (movement * speed);
	}
}
