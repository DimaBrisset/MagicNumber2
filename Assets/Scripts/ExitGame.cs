using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    #region Variables

    public Button ExitButton;

    #endregion


    #region lifecycle

    private void Start()
    {
        ExitButton.onClick.AddListener(ExitButtonClicked);
    }

    #endregion


    #region Private Methods

    private void ExitButtonClicked()
    {
        EditorApplication.isPlaying = false;
        Application.Quit();
    }

    #endregion
}