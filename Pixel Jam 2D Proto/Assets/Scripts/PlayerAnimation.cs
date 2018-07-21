using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
	[SerializeField] private PlayerController playerController;

	[SerializeField] private Animator animator;

	void Awake ()
	{
		if (playerController == null)
		{
			Debug.Log ("Don't forget to set the Player Controller for the Player Animation");
			playerController = GetComponent<PlayerController>();
		}
		if (animator == null)
		{
			Debug.Log ("Don't forget to set the Animator for the Player Animation");
			animator = GetComponent<Animator>();
		}
	}

	void Update ()
	{
		if (playerController.facingLeft)
		{
			// Left facing animations
			if (playerController.moveHorizontal < 0 | playerController.moveVertical != 0)
			{
				animator.SetInteger ("WalkState", 3); // Walk left animation
			}
			else
			{
				animator.SetInteger ("WalkState", 1); // Idle left animation
			}
		}
		else
		{
			// Right facing animations
			if (playerController.moveHorizontal > 0 | playerController.moveVertical != 0)
			{
				animator.SetInteger ("WalkState", 2); // Walk right animation
			}
			else
			{
				animator.SetInteger ("WalkState", 0); // Idle right animation (default)
			}
		}
	}
}
