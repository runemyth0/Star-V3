using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDetail : MonoBehaviour
{
	private int defaultID;
	private int targetID;

	private SpriteRenderer renderer2D;

	void Awake ()
	{
		// Get renderer and sort layer IDs
		renderer2D = GetComponentInParent<SpriteRenderer>();
		defaultID = renderer2D.sortingLayerID;
		targetID = GetComponentInChildren<SpriteRenderer>().sortingLayerID;
	}

	void OnTriggerEnter2D ()
	{
		// Change sorting layer to frontal detail
		renderer2D.sortingLayerID = targetID;
	}

	void OnTriggerExit2D ()
	{
		// Change sortinglayer back to normal
		renderer2D.sortingLayerID = defaultID;
	}
}
