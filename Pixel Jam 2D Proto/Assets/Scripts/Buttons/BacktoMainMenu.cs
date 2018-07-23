using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BacktoMainMenu : MonoBehaviour {

    public Button MainButton;

    void Start()
    {
        Button btn = MainButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }
}
