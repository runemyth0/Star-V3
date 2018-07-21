using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractDropoff : MonoBehaviour
{
	[SerializeField] private Text dropoffText;

	[SerializeField] private GameObject controller;

	private GameController gameController;

	void Awake ()
	{
		dropoffText.text = "";

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
			dropoffText.text = "Press E to deposit resources";
			if (Input.GetKeyDown (KeyCode.E))
			{
				gameController.fuel += gameController.fuelCount;
				gameController.fuelCount -= gameController.fuelCount;
			}
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		dropoffText.text = "";
	}
}
