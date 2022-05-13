using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int ScoreNumber = 0;

    private void Start()
    {
        ScoreNumber = 0;
    }

    private void Update()
    {
        GetComponent<Text>().text = ScoreNumber.ToString();
    }
}