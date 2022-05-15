using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerLeft : MonoBehaviour
{
    public float MaxTime = 0.3f;
    public GameObject ObstaclePrefab;
    public float Width;
    private float _timer = 0f;

    private void Start()
    {
        GameObject newObstacle = Instantiate(ObstaclePrefab, this.transform);
        newObstacle.transform.position = transform.position + new Vector3(0f, Random.RandomRange(-Width, Width), 0f);
    }

    private void Update()
    {
        if (_timer > MaxTime)
        {
            GameObject newObstacle = Instantiate(ObstaclePrefab, this.transform);
            newObstacle.transform.position = transform.position + new Vector3(0f, Random.RandomRange(-Width, Width), 0f);

            Destroy(newObstacle, 10f);
            _timer = 0f;
        }
        _timer += Time.deltaTime;
    }
}