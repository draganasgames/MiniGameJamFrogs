using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObstacleSpawnerUP : MonoBehaviour
{
    public float MaxTime = 0.3f;
    public GameObject FlorPrefab;
    public float Width;
    private float _timer = 0f;

    private void Start()
    {
        GameObject newObstacle = Instantiate(FlorPrefab, this.transform);
        newObstacle.transform.position = transform.position + new Vector3(Random.RandomRange(-Width, Width), 0f, 0f);
    }

    private void Update()
    {
        if (_timer > MaxTime)
        {
            GameObject newObstacle = Instantiate(FlorPrefab, this.transform);
            newObstacle.transform.position = transform.position + new Vector3(Random.RandomRange(-Width, Width), 0f, 0f);

            Destroy(newObstacle, 10f);
            _timer = 0f;
        }
        _timer += Time.deltaTime;
    }
}