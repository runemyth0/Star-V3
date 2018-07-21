using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractTakeoff : MonoBehaviour
{
	[SerializeField] private Text takeoffText;

	[SerializeField] private GameObject controller;

	[SerializeField] private GameController gameController;

	void Awake ()
	{
		takeoffText.text = "";

		if (controller == null)
		{
			controller = GameObject.FindWithTag ("GameController");
		}
		gameController = controller.GetComponent<GameController>();
	}

	void OnTriggerStay2D (Collider2D other)
	{
		if (other.tag == "Player" && gameController.fuel >= gameController.fuelMax)
		{
			takeoffText.text = "Press 'E' to board your ship";
			if (Input.GetKeyDown (KeyCode.E))
			{
				gameController.Takeoff ();
			}
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		takeoffText.text = "";
	}
}
