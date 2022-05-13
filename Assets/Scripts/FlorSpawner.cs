using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlorSpawner : MonoBehaviour
{
    public float MaxTime = 1f; // vreme koje cekamo da se novi pod pojavi
    public GameObject Flor;
    public float Width;
    private float _timer = 0f;

    private void Start()
    {
        GameObject newObstacle = Instantiate(Flor);
        newObstacle.transform.position = transform.position + new Vector3(Random.RandomRange(-Width, Width), 0f, 0f);
    }

    private void Update()
    {
        // svaki put kada je varijabla _timer veca od MaxTime varijable
        if (_timer > MaxTime)
        {
            // instancira se novi prefab kome se dodeljuje pozicija
            GameObject newObstacle = Instantiate(Flor);
            newObstacle.transform.position = transform.position + new Vector3(Random.RandomRange(-Width, Width), 0f, 0f);

            // za odredjeno vreme, u nasem slucaju 15 sekundi unistavaju se objekti jedan po jedan i varijablu _timer vracamo na 0
            Destroy(newObstacle, 15f);
            _timer = 0f;
        }
        _timer += Time.deltaTime;
    }
}