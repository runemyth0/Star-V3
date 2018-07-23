using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractPickup : MonoBehaviour
{
	public float fuelValue;

	[SerializeField] private Text pickupText;

	[SerializeField] private GameObject controller;

	[SerializeField] private GameController gameController;

	void Awake ()
	{
		pickupText.text = "";

		fuelValue = Mathf.Floor (Random.Range (5.0f, 20.99f));

		if (controller == null)
		{
			controller = GameObject.FindWithTag ("GameController");
		}
		gameController = controller.GetComponent<GameController>();
	}

	void OnTriggerStay2D (Collider2D other)
	{
		if (other.tag == "Player")
		{
			if (gameController.fuelCount + fuelValue <= gameController.fuelCarry)
			{
				pickupText.text = "Press 'E' to pick up " + fuelValue + " " + gameObject.tag;
				if (Input.GetKeyDown (KeyCode.E))
				{
					gameController.fuelCount += fuelValue;
					Destroy (gameObject);
				}
			}
			else if (gameController.fuelCount + fuelValue > gameController.fuelCarry)
			{
				pickupText.text = "Can't carry " + fuelValue + " " + gameObject.tag + "!";
			}
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		pickupText.text = "";
	}
}
