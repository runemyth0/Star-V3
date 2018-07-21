using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public bool pause;
	public bool gameOver;

	public float fuel;
	public float fuelCount;
	public float fuelCarry;
	public float fuelMax;

	[SerializeField] private float resourceCount;
	[SerializeField] private float resourceRange;

	[SerializeField] private float detailDensity;
	[SerializeField] private float detailRange;

	[SerializeField] private Text fuelText;
	[SerializeField] private Text fuelCarryText;
	[SerializeField] private Text leaveText;

	public GameObject resource;
	public GameObject detail;

	void Awake ()
	{
		leaveText.text = "";
		fuel = 0;
		fuelText.text = fuel + "/" + fuelMax;
		fuelCarryText.text = fuelCount + "/" + fuelCarry;
		SpawnResources ();
		SpawnDetails ();
	}

	void Update ()
	{
		fuelText.text = fuel + "/" + fuelMax;
		fuelCarryText.text = fuelCount + "/" + fuelCarry;

		if (gameOver)
		{
			GameOver ();
		}
	}

	void GameOver () // ALERT: Currently broken!
	{
		GameObject player = GameObject.FindWithTag ("Player"); // Find the player
		PlayerController playerController = player.GetComponent<PlayerController>(); // Get the PlayerController script
		playerController.moveHorizontal = 0; // Prevent movement in horizontal
		playerController.moveVertical = 0; // and vertical
	}

	public void Takeoff ()
	{
		fuel -= fuelMax;
		pause = true; // Pauses the countdown timer (see CountdownTimer script for more info)
		leaveText.text = "Preparing for takeoff...";
	}

	// Creates and distributes the resource (Fuel) across the map
	// Recommend range of 1000 or greater
	void SpawnResources ()
	{
		for (int i = 0; i < resourceCount; i++)
		{
			Instantiate (resource, new Vector2 (Random.Range (-1.0f,1.0f) * (resourceRange), Random.Range (-1.0f, 1.0f) * (resourceRange)), Quaternion.identity, GameObject.FindWithTag ("ResourceBin").transform);
		}
	}

	// Creates and distributes the selected detail across the map
	// Recommend range of 2000 or greater
	void SpawnDetails ()
	{
		DetailSelect detailSelect = GetComponent<DetailSelect>();
		for (int i = 0; i < detailDensity; i++)
		{
			detailSelect.GenerateDetail ();
			detail = detailSelect.selectedDetail;
			Instantiate (detail, new Vector2 (Random.Range (-1.0f,1.0f) * (detailRange), Random.Range (-1.0f, 1.0f) * (detailRange)), Quaternion.identity, GameObject.FindWithTag ("DetailBin").transform);
		}
	}
}
