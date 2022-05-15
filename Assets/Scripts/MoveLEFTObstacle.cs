using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLEFTObstacle : MonoBehaviour
{
    public float Speed = 10;

    private void Update()
    {
        transform.position += Vector3.right * Speed * Time.deltaTime;
    }
}