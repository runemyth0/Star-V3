using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	private Vector3 offset;

	public GameObject player;

	void Awake ()
	{
		if (player == null)
		{
			Debug.Log ("Please enter a value for the player game object.");
			player = GameObject.FindWithTag ("Player");
		}
		offset = transform.position - player.transform.position;
	}

	void LateUpdate ()
	{
		transform.position = offset + player.transform.position;
	}
}
