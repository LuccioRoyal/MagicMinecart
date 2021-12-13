using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Components")]
    private Rigidbody2D rb;

    [Header("Variables")]
    [SerializeField] private float playerSpeed;
    [SerializeField] private float moveSpeed;

    [Header("Lanes stuff")]
    [SerializeField] int[] lanes;
    [SerializeField] int currentLane;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MyInput();
        rb.velocity = new Vector2(0, playerSpeed);

        checkLane();
        switchLane();
    }

    private void MyInput()
    {
        if (Input.GetKeyDown(KeyCode.A)) currentLane--;
        if (Input.GetKeyDown(KeyCode.D) && currentLane < lanes.Length - 1) currentLane++;
    }

    private void checkLane()
    {
        if (currentLane < 0) currentLane = 0;
    }

    private void switchLane()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(lanes[currentLane], transform.position.y), moveSpeed * Time.deltaTime);
    }

    public int[] returnLanes()
    {
        return lanes;
    }
}
