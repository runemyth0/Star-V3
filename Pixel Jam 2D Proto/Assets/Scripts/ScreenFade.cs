using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFade : MonoBehaviour
{
	[SerializeField] private float fadeRate;

	private Color color;

	void Awake ()
	{
		color = GetComponent<SpriteRenderer>().color;
	}

	void Update ()
	{
		//
	}

	void FadeIn ()
	{

	}

	void FadeOut ()
	{

	}
}
