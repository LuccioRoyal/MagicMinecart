using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonObstacle : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] GameObject obstacle;
    [SerializeField] GameObject coin;

    [Header("Variables")]
    [SerializeField] int[] lanes;
    [SerializeField] float intervall;
    float maxIntervall;

    float coinIntervall;
    float coinMaxIntervall;

    int temp;
    int temp2;

    private void Start()
    {
        lanes = GameObject.Find("Player").GetComponent<PlayerMovement>().returnLanes();
        maxIntervall = intervall;

        coinMaxIntervall = intervall + 1;
        coinIntervall = coinMaxIntervall;
    }

    private void Update()
    {
        intervall -= Time.deltaTime;
        if (intervall < 0)
        {
            temp2 = temp;
            spawnObject();
            intervall = maxIntervall;
        }

        coinIntervall -= Time.deltaTime;
        if (coinIntervall < 0)
        {
            int j = Random.Range(0, lanes.Length);
            Instantiate(coin, new Vector2(lanes[j], transform.position.y), transform.rotation);
            coinIntervall = coinMaxIntervall;
        }
    }

    private void spawnObject()
    {
        int j = Random.Range(0, lanes.Length);
        temp = j;
        Instantiate(obstacle, new Vector2(lanes[j], transform.position.y), transform.rotation);

        if (temp == temp2) Instantiate(coin, new Vector2(lanes[j], transform.position.y - maxIntervall), transform.rotation);
    }
}
