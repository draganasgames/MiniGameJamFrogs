using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverCanvas;

    private void Start()
    {
        // zapocinje igru 
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        // kada dodje do kolizije pojavljuje se 'GameOver' panel i igra se zaustavlja
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void PlayGame()
    {
        // ucitava igru
        SceneManager.LoadScene(0);
    }
}
