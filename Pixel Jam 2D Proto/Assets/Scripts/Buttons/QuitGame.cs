using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour {

    public Button QuitButton;

	// Use this for initialization
	void Start ()
    {
        Button btn = QuitButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
	
	// Update is called once per frame
	void TaskOnClick ()
    {
        Application.Quit();
	}
}
