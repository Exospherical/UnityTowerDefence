using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{


    // The TextMesh Component
    TextMesh tm;

    // Use this for initialization
    void Start()
    {
        tm = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        // Face the Camera
        transform.forward = Camera.main.transform.forward;
    }

    public int current()
    {
        return tm.text.Length;
    }

    // Decrease the current Health by removing one '-'
    public void decrease()
    {
        if (current() > 1)
        {
            tm.text = tm.text.Remove(tm.text.Length - 1);
        }
        else
        {
            Destroy(transform.parent.gameObject);
            PlayerStatistics.enemiesKilled++;
            addMonsterKillScore();
        }
    }

    public void addMonsterKillScore()
    {
        PlayerStatistics.points += 50;
    }


}
