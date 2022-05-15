using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public string Name;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        // zapocinje igru 
        Time.timeScale = 1f;
    }

    public void GameOver(Score timer, GameObject finish)
    {
        HiScoreHandler.Instance.addToDictionary(new HiScore(Name, (float)Math.Round(timer.ScoreNumber, 2)));
        // kada dodje do kolizije pojavljuje se 'GameOver' panel i igra se zaustavlja
        finish.SetActive(true);
        Time.timeScale = 0f;
    }
    public void setName(string name)
    {
        Name= name;
    }
    public void PlayGame()
    {
        // ucitava igru
        SceneManager.LoadScene(0);
    }
}
