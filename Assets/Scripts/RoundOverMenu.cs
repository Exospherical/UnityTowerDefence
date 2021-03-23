using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RoundOverMenu : MonoBehaviour
{
    public GameObject roundOverMenu;
    public bool isGameOver = false;

    public Text enemiesKilledText;

    
    public void endRound()
    {
        enemiesKilledText.text = "You Killed: "+ PlayerStatistics.enemiesKilled + " enemies";
        roundOverMenu.SetActive(true);
    }
    public void restart()
    {
        roundOverMenu.SetActive(false);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    static void quit()
    {
    }
}
