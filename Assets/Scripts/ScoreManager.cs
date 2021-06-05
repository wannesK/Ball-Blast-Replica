using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int hightScore;

    //#region Singleton
    //public static ScoreManager instance;
    //private void Awake()
    //{
    //    if (instance != null && instance != this)
    //    {
    //        Destroy(this.gameObject);
    //        return;
    //    }

    //    instance = this;
    //    DontDestroyOnLoad(this.gameObject);
    //}
    //#endregion

    private void Start()
    {
        if (PlayerPrefs.HasKey("hightScore"))
        {
            hightScore = PlayerPrefs.GetInt("hightScore");
        }

    }
    public int IncreaseScore(int value)
    {
        score += value;

        CheckHightScore();
        return score;
    }

    public void CheckHightScore()
    {
        if (score > PlayerPrefs.GetInt("hightScore"))
        {
            hightScore = score;
            PlayerPrefs.SetInt("hightScore", hightScore);            
        }
    }

}
