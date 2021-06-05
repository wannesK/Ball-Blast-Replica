using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int healt = 1;

    public GameObject deadEffect;
    public UIController ui;
    
    public void DecreasePlayerHealth()
    {
        healt--;

        ChekHealth();
    }
    private void ChekHealth()
    {
        if (healt < 1)
        {
            ScaleTime();

            var effectClone = Instantiate(deadEffect, transform.position, Quaternion.identity);

            Destroy(gameObject);
            Destroy(effectClone, 0.5f);

            ui.SetActiveDeadScreen();
        }
    }

    private void ScaleTime()
    {
        Time.timeScale = 0.4f;        
    }

}
