using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
	// This script handles the timer that governs the game over condition
	// Local variables that must be plugged in are the time limit (in seconds) and the GameController object

	public float countdown;

	[SerializeField] private float timeLimit;

	[SerializeField] private Text timerText;

	[SerializeField] private GameObject controller;

	[SerializeField] private GameController gameController; // This probably does not need to be serialized, but will remain as such for testing purposes

	void Awake ()
	{
		// Grabs the GameController script from the GameController object
		if (controller == null)
		{
			controller = GameObject.FindWithTag ("GameController");
		}
		gameController = controller.GetComponent<GameController>();

		if (timerText == null)
		{
			Debug.Log ("Please set the timer text object.");
		}
		countdown = timeLimit; // Sets start time
		ComplexText (); // Runs timer print function for the first time
	}

	void FixedUpdate ()
	{
		if (gameController.pause)
		{
			countdown = countdown; // Freezes countdown timer if game is paused
		}
		else
		{
			countdown -= Time.fixedDeltaTime; // Subtracts time from countdown timer
			if (countdown <= 0.0f)
			{
				countdown = 0; // Sets countdown value to 0 if it would go below zero
				gameController.gameOver = true; // Set game over flag to true
			}
		}

		ComplexText ();
	}

	void ComplexText ()
	{
		// This function handles the actual calculations of generating the countdown timer.
		// It is set up in the 00:00:000 (MM:SS:MS) format

		float minutes;
		float seconds;
		float fraction;
		float milliseconds;

		string minutesString;
		string secondsString;
		string millisecondsString;

		minutes = Mathf.Floor (countdown / 60); // Gets minutes value
		seconds = Mathf.Floor (countdown % 60); // Gets seconds value
		fraction = countdown * 1000;
		milliseconds = Mathf.Floor (fraction % 1000);

		// Converts minutes value to 00 format
		if (minutes < 10)
		{
			minutesString = "0" + minutes.ToString ();
		}
		else
		{
			minutesString = minutes.ToString ();
		}

		// Converts seconds value to 00 format
		if (seconds < 10)
		{
			secondsString = "0" + seconds.ToString ();
		}
		else
		{
			secondsString = seconds.ToString ();
		}

		// Converts milliseconds value to 000 format
		if (milliseconds < 10)
		{
			millisecondsString = "00" + milliseconds.ToString ();
		}
		else if (milliseconds < 100)
		{
			millisecondsString = "0" + milliseconds.ToString ();
		}
		else
		{
			millisecondsString = milliseconds.ToString ();
		}

		// Prints a formatted time string to the 'timerText' object
		timerText.text = minutesString + ":" + secondsString + ":" + millisecondsString;
	}
}
