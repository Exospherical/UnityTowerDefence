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
        gameOverMenu.SetActive(true);
    }
    public void restart()
    {
        gameOverMenu.SetActive(false);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    static void quit()
    {
    }
}
