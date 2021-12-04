using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public Rigidbody2D rb;

    private void Update()
    {
        rb.velocity = new Vector2(0, playerSpeed);
    }
}
