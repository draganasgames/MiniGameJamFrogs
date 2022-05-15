using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float ScoreNumber = 0;

    private void Start()
    {
        ScoreNumber = 0;
    }

    private void Update()
    {
        ScoreNumber += Time.deltaTime;
        GetComponent<Text>().text = Math.Round(ScoreNumber, 2).ToString();
    }
}