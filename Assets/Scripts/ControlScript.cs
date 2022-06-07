using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControlScript : MonoBehaviour
{
    #region Variables

    public TextMeshProUGUI InfoLabel;
    public TextMeshProUGUI GuessLabel;
    public TextMeshProUGUI CalcClickLable;
    public Button MoreButton;
    public Button LessButton;
    public Button FinishButton;
    public Button StartButton;
    public int Min = 1;
    public int Max = 1000;

    private int _min;
    private int _max;
    private int _guess;
    private int _calculatedClick;

    # endregion


    #region LifeCycle

    private void Start()
    {
        _min = Min;
        _max = Max;
        MoreButton.onClick.AddListener(MoreButtonClicked);
        LessButton.onClick.AddListener(LessButtonClicked);
        FinishButton.onClick.AddListener(FinishButtonClicked);
        SetInfoText($"Загадай число от {Min} до {Max}.");
        CalculateGuess();
    }

    #endregion


    #region Private Metods

    private void CalculateGuess()
    {
        _guess = (Min + Max) / 2;
        SetGuessText($"Твое число: {_guess}?");
    }

    private void SetInfoText(string text)
    {
        InfoLabel.text = text;
    }

    private void SetGuessText(string text)
    {
        GuessLabel.text = text;
    }

    private void SetCalculatedStep(string text)
    {
        CalcClickLable.text = text;
    }

    private void MoreButtonClicked()
    {
        Min = _guess;
        CalculateGuess();
        StepsCalculation();
    }

    private void FinishButtonClicked()
    {
        SetGuessText($"Победа! Твое число: {_guess}");
        SetCalculatedStep($"Число ходов {_calculatedClick}");
    }

    private void LessButtonClicked()
    {
        Max = _guess;
        CalculateGuess();
        StepsCalculation();
    }

    private void StepsCalculation()
    {
        _calculatedClick++;
        SetCalculatedStep($"Число ходов {_calculatedClick}");
    }

    #endregion
}