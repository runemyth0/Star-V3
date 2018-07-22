using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGeneration : MonoBehaviour
{
	private int terrainValue;

	public Sprite selectedTile;

	[SerializeField] private Sprite tile1;
	[SerializeField] private Sprite tile2;
	[SerializeField] private Sprite tile3;
	[SerializeField] private Sprite tile3b;
	[SerializeField] private Sprite tile3c;
	[SerializeField] private Sprite tile4a;
	[SerializeField] private Sprite tile4b;
	[SerializeField] private Sprite tile4c;
	[SerializeField] private Sprite tile4d;
	[SerializeField] private Sprite tile5a;
	[SerializeField] private Sprite tile5b;
	[SerializeField] private Sprite tile5c;
	[SerializeField] private Sprite tile6;
	[SerializeField] private Sprite tile7;
	[SerializeField] private Sprite tile8a;
	[SerializeField] private Sprite tile8b;
	[SerializeField] private Sprite tile8c;

	void Awake ()
	{
		terrainValue = Mathf.RoundToInt (Random.Range (0.0f,17.0f));

		switch (terrainValue)
		{
			case 0:
				selectedTile = tile1;
				break;
			case 1:
				selectedTile = tile2;
				break;
			case 2:
				selectedTile = tile3;
				break;
			case 3:
				selectedTile = tile3b;
				break;
			case 4:
				selectedTile = tile3c;
				break;
			case 5:
				selectedTile = tile4a;
				break;
			case 6:
				selectedTile = tile4b;
				break;
			case 7:
				selectedTile = tile4c;
				break;
			case 8:
				selectedTile = tile4d;
				break;
			case 9:
				selectedTile = tile5a;
				break;
			case 10:
				selectedTile = tile5b;
				break;
			case 11:
				selectedTile = tile5c;
				break;
			case 12:
				selectedTile = tile6;
				break;
			case 13:
				selectedTile = tile7;
				break;
			case 14:
				selectedTile = tile8a;
				break;
			case 15:
				selectedTile = tile8b;
				break;
			case 16:
				selectedTile = tile8c;
				break;
			default:
				selectedTile = null;
				break;
		}

		GetComponent<SpriteRenderer>().sprite = selectedTile;
	}
}
