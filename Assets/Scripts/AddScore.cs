using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private int lastScoreValue = 0;
    private BoxCollider2D ScoreBoxCollider;

    private void Start()
    {
        ScoreBoxCollider = GetComponent<BoxCollider2D>();
        lastScoreValue = Score.ScoreNumber;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.ScoreNumber++;
        if (Score.ScoreNumber != lastScoreValue)
        {
            ScoreBoxCollider.gameObject.SetActive(false);
        }
    }
}