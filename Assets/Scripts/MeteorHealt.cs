using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MeteorHealt : MonoBehaviour
{    
    public int health = 331;

    public TextMeshPro healtText;
    public GameObject effect;
    public MissileUp missile;

    private ScoreManager scoreManager;
    private UIController ui;

    private void Awake()
    {
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
        ui = GameObject.FindGameObjectWithTag("Canvas").GetComponent<UIController>();
    }
    private void Start()
    {
        healtText.text = health.ToString();
    }

    public void TakeDamage()
    {
        health -=  missile.missileDamage;

        healtText.text = health.ToString();

        CheckHealth();
    }
    private void CheckHealth()
    {
        if (health < 1)
        {
            Destroy(gameObject);

            Instantiate(effect, transform.position, Quaternion.identity);

            //ScoreManager.instance.IncreaseScore(Random.Range(10, 20)); 
            scoreManager.IncreaseScore(Random.Range(10,20));

            ui.ChangeScoreText();
        }
    }
}
