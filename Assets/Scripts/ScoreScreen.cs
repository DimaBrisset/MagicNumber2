using TMPro;
using UnityEngine;

public class ScoreScreen : MonoBehaviour
{
    #region Variables

    public TextMeshProUGUI ScoreLabel;

    #endregion


    #region LifeCycle

    private void Update()
    {
        ScoreLabel.text = ScoreManager.Instance.Score.ToString();
    }

    #endregion
}