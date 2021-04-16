using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatistics : MonoBehaviour
{

    public TextMeshProUGUI scoreUIelement;
    public static int points;
    public int startingMoney = 400;

    public static int enemiesKilled;
    public int enemiesKilledReset = 0;

    void Start()
    {
        points = startingMoney;
        enemiesKilled = enemiesKilledReset;
    }

    private void Update()
    {
        scoreUIelement.text = "$" + PlayerStatistics.points.ToString();
        
        if (enemiesKilled == 11)
        {
            FindObjectOfType<RoundOverMenu>().endRound();
        }
        

    }
}