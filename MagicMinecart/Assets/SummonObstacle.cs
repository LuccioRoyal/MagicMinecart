using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonObstacle : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] GameObject obstacle;

    [Header("Variables")]
    [SerializeField] int[] lanes;
    [SerializeField] float intervall;
    float maxIntervall;

    private void Start()
    {
        lanes = GameObject.Find("Player").GetComponent<PlayerMovement>().returnLanes();
        maxIntervall = intervall;
    }

    private void Update()
    {
        intervall -= Time.deltaTime;
        if (intervall < 0)
        {
            spawnObject();
            intervall = maxIntervall;
        }
    }

    private void spawnObject()
    {
        Instantiate(obstacle, new Vector2(lanes[Random.Range(0, lanes.Length)], transform.position.y), transform.rotation);
    }
}
