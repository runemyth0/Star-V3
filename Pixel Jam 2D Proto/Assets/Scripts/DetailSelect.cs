using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetailSelect : MonoBehaviour
{
	private int detailValue;

	public GameObject selectedDetail;

	[SerializeField] private GameObject detailRock1;
	[SerializeField] private GameObject detailRock2;
	[SerializeField] private GameObject detailRock3;
	[SerializeField] private GameObject detailRock4;
	[SerializeField] private GameObject detailRock5;
	[SerializeField] private GameObject detailRock6;
	[SerializeField] private GameObject detailRock7;

	void Awake ()
	{
		GenerateDetail ();
	}

	public void GenerateDetail ()
	{
		detailValue = Mathf.RoundToInt (Random.Range (0.0f, 7.0f));

		switch (detailValue)
		{
			case 1:
				selectedDetail = detailRock1;
				break;
			case 2:
				selectedDetail = detailRock2;
				break;
			case 3:
				selectedDetail = detailRock3;
				break;
			case 4:
				selectedDetail = detailRock4;
				break;
			case 5:
				selectedDetail = detailRock5;
				break;
			case 6:
				selectedDetail = detailRock6;
				break;
			case 7:
				selectedDetail = detailRock7;
				break;
			default:
				selectedDetail = detailRock1;
				break;
		}
	}
}
