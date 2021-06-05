using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIController : MonoBehaviour
{
    public GameObject deadScreen;
    public ScoreManager scoreManager;

    public TextMeshProUGUI totalScoreText;
    public TextMeshProUGUI inGameScoreText;

    private void Start()
    {
        Time.timeScale = 1f;
        ChangeScoreText();
    }

    public void SetActiveDeadScreen()
    {
        StartCoroutine(DeadScreen());        
    }
    private IEnumerator DeadScreen()
    {
        yield return new WaitForSeconds(0.65f);

        deadScreen.SetActive(true);
        Time.timeScale = 0f;
    } 
    
    public void RestartButton()
    {
        SceneManager.LoadScene("Main");
    }
    public void QuitButton()
    {
        Application.Quit();
    }

    public void ChangeScoreText()
    {
        inGameScoreText.text = "Score : " + scoreManager.score;
        totalScoreText.text = "Hight Score: " + PlayerPrefs.GetInt("hightScore");
    }
}
