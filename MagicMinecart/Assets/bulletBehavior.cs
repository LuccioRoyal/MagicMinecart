using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehavior : MonoBehaviour
{
    public float bulletSpeed;
    public Vector2 targetPosition;
    public Rigidbody2D rb;

    public float bulletLifeSpan;

    private void Start()
    {
        rb.AddForce(transform.right * bulletSpeed,ForceMode2D.Impulse);

    }


    public void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, targetPosition, bulletSpeed*Time.deltaTime);

        bulletLifeSpan -= Time.deltaTime;
        if (bulletLifeSpan < 0) Destroy(gameObject);
    }
}
