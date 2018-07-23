using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float moveHorizontal;
	public float moveVertical;

	[SerializeField] private float speed;

	public bool facingLeft; // This boolean governs whether the player will be facing left or right
	// Ties into animation system (if we get that far)

	void Awake ()
	{
		facingLeft = false; // The player's sprite should always start facing right
	}

	void FixedUpdate ()
	{
		moveHorizontal = Input.GetAxis ("Horizontal"); // Get horizontal (x-axis) input
		moveVertical = Input.GetAxis ("Vertical"); // Get vertical (y-axis) input

		Vector3 movement = new Vector3 (moveHorizontal,moveVertical,0); // Creates a directional unit vector
		transform.position += movement * speed; // Multiplies directional unit vector by speed and applies it to the player's transform
			if (transform.position.x > 1250)
			{
				transform.position = new Vector3 (1250,transform.position.y,0);
			}
			else if (transform.position.x < -1250)
			{
				transform.position = new Vector3 (transform.position.x,1250,0);
			}
			if (transform.position.y > 1250)
			{
				transform.position = new Vector3 (-1250,transform.position.y,0);
			}
			else if (transform.position.y < -1250)
			{
				transform.position = new Vector3 (transform.position.x,-1250,0);
			}
		LeftCheck (); // Updates facing boolean
	}

	void LeftCheck ()
	{
		if (Input.GetKeyDown (KeyCode.LeftArrow) | Input.GetKeyDown (KeyCode.A))
		{
			facingLeft = true;
		}
		else if (Input.GetKeyDown (KeyCode.RightArrow) | Input.GetKeyDown (KeyCode.D))
		{
			facingLeft = false;
		}
	}
}
