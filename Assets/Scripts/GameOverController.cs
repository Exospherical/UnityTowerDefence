using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{

    public GameObject gameOverMenu;
    public bool isGameOver = false;

    public void endGame()
    {
        Time.timeScale = 0;
        gameOverMenu.SetActive(true);
    }
    public void restart()
    {
        Time.timeScale = 1;
        gameOverMenu.SetActive(false);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void quit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu_Scene");
    }
}
