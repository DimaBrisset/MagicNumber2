using System;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    public int Score;

    private static ScoreManager _instance;
    public static ScoreManager Instance => _instance;

    private void Awake()
    {
     
      if (_instance!=null)
      {
          Destroy(gameObject);
          return;
      }
      
      
      
        
      _instance = this;
      DontDestroyOnLoad(gameObject);
    }

    public void ChangeScore(int score)
    {
        Score += score;
    }

    public void FinishScore()
    {
        Score = 0;
    }
    
   
   
}