using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControlScript : MonoBehaviour
{
    public TextMeshProUGUI InfoLabel;
    public TextMeshProUGUI GuessLabel;
    public TextMeshProUGUI CalculatedLabel;
    public Button MoreButton;
    public Button LessButton;
    public Button StartButton;
    public Button FinishButton;
    public int Min = 1;
    public int Max = 100;

    private int _min;
    private int _max;
    private int _guess;
    private int _calculatedClick;

    private void Start()
    {
        _min = Min;
        _max = Max;
        MoreButton.onClick.AddListener(MoreButtonClicked);
        LessButton.onClick.AddListener(LessButtonClicked);
        FinishButton.onClick.AddListener(FinishButtonClicked);
        StartButton.onClick.AddListener(StartButtonClicked);
      
        SetInfoText($"Загадай число от {Min} до {Max}.");
        CalculateGuess();
    } 

 

    private void SetInfoText(string text)
    {
        InfoLabel.text = text;
    }

    private void SetGuessText(string text)
    {
        GuessLabel.text = text;
    }

    private void SetCalculatedText(string text)
    {
        CalculatedLabel.text = text;
    }

    private void StartButtonClick()
    {
        SetCalculatedText(String.Empty);
        _calculatedClick = 0;
        CalculateGuess();
    }

    private void CalculateGuess()
    {
        _guess = (Min + Max) / 2;

        SetGuessText($"Твое число: {_guess}?");
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

    private void SetCalculatedStep(string text)
    {
        CalculatedLabel.text = text;
    }

    private void MoreButtonClicked()
    {
        Min = _guess;
        CalculateGuess();
        StepsCalculation();
    }

    private void StartButtonClicked()
    {
        SetCalculatedStep(string.Empty);
        SetGuessText(string.Empty);
        _calculatedClick = 0;
        Min = _min;
        Max = _max;
        CalculateGuess();
        
        
        
    }

    private void StepsCalculation()
    {
        _calculatedClick++;
        SetCalculatedStep($"Число ходов {_calculatedClick}");
    }
  
    
}