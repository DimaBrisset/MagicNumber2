using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    public Button ExitButton;

    private void Start()
    {
        ExitButton.onClick.AddListener(ExitButtonClicked);
    }

    void Update()
    {
        ExitButton.onClick.AddListener(ExitButtonClicked);
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void ExitButtonClicked()
    {
        Application.Quit();
    }
}