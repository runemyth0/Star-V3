using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceflightLoad : MonoBehaviour
{
	void Update ()
	{
		if (transform.position.x > -350)
		{
			SceneManager.LoadScene ("Game", LoadSceneMode.Single);
		}
	}
}
