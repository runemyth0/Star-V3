using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
        public Button StartButton;

        void Start()
        {
            Button btn = StartButton.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }

        void TaskOnClick()
        {
            SceneManager.LoadScene("Game", LoadSceneMode.Single);
        }
    }
