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

    void Start()
    {
        points = startingMoney;
    }

    private void Update()
    {
        scoreUIelement.text = "$" + PlayerStatistics.points.ToString();
    }
}