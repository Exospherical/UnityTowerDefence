using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatistics : MonoBehaviour
{
    public static int points;
    public int startingMoney = 400;

     void Start()
    {
        points = startingMoney; 
    }
}
