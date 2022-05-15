using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Frog : MonoBehaviour
{
    public float Velocity = 1f;
    private Rigidbody2D FrogRB;
    private float speed = 5;
    public int NumberOfJumps = 3;
    public float NumberOfJump=3;
    private float Height=0;
    public Score timer;
    public GameObject finish;
    public Text finishText;
    private void Start()
    {
        FrogRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (NumberOfJump == NumberOfJumps && transform.position.y < Height)
        {
            NumberOfJump--;
            Height = transform.position.y;
        }
        //walk
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * -speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        //jump
        if (Input.GetKeyDown(KeyCode.Space) && NumberOfJump< NumberOfJumps)
        {
            Height = transform.position.y;
            NumberOfJump++;
            FrogRB.velocity = Vector2.up * Velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Ground")
        {
            finishText.text = Math.Round(timer.ScoreNumber, 2).ToString();
            GameManager.Instance.GameOver(timer, finish);
        }
        else
        {
            NumberOfJump = 0;
        }
        //if (collision.gameObject.tag != "Life")
        //    GameManager.GameOver();
    }
}