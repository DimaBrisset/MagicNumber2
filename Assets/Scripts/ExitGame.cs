
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    public Button ExitButton;

    private void Start()
    {
        ExitButton.onClick.AddListener(ExitButtonClicked);
    }

  

    private void ExitButtonClicked()
    {
        EditorApplication.isPlaying = false;
        Application.Quit();
    }

    
    
    
}