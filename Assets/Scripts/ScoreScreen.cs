using TMPro;
using UnityEngine;

public class ScoreScreen : MonoBehaviour
{
    public TextMeshProUGUI ScoreLabel;
   
    private void Update()
    {
        ScoreLabel.text = ScoreManager.Instance.Score.ToString();
 
    }
}
