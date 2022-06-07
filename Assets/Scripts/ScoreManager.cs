using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    #region Variables

    public int Score;

    public static ScoreManager Instance => _instance;

    private static ScoreManager _instance;

    #endregion


    #region lifecycle

    private void Awake()

    {
        /*
         if (_instance!=null)
         {
             Destroy(gameObject);
             return;
         }
         */


        _instance = this;
        DontDestroyOnLoad(gameObject);
    }

    #endregion


    #region Public Methods

    public void ChangeScore(int score)
    {
        Score += score;
    }

    #endregion
}