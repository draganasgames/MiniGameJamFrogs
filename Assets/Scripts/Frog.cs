using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    public float Velocity = 1f;
    private Rigidbody2D FrogRB;
    private float speed = 5;

    private void Start()
    {
        FrogRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //walk
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.right * -speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        //jump
        if (Input.GetKeyDown(KeyCode.Space))
            FrogRB.velocity = Vector2.up * Velocity;
    }
}