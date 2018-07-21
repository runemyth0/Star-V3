using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseSpawn : MonoBehaviour
{
	private int xCoord;
	private int yCoord;

	private GameController gameController;

	void Awake ()
	{
		if (gameController == null)
		{
			gameController = GetComponent<GameController>();
		}

		xCoord = -1000;
		yCoord = -1000;

		while (yCoord <= 1000)
		{
			while (xCoord <= 1000)
			{
				Spawn (Mathf.Clamp (Mathf.PerlinNoise (xCoord, yCoord), 0.0f, 1.0f));
				xCoord++;
			}
			yCoord++;
		}
	}

	void Update ()
	{

	}

	void Spawn (float spawnVal)
	{
		if (spawnVal > 0.75)
		{
			// Spawn resources
			Debug.Log ("Spawn Resource");
			Instantiate (gameController.resource, new Vector2 (xCoord, yCoord), Quaternion.identity, GameObject.FindWithTag ("ResourceBin").transform);
		}
		else if (spawnVal <= 0.50)
		{
			// Spawn environment details
			Debug.Log ("Spawn Details");
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Fuel")
		{
			Destroy (other.gameObject);
		}
	}
}
