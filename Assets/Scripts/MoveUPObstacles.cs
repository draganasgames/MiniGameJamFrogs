using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUPObstacles : MonoBehaviour
{
    public float Speed=10;

    private void Update()
    {
        transform.position += Vector3.down * Speed * Time.deltaTime;
        transform.Rotate(0, 0, 1);
    }
}