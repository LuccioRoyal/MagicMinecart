using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack2 : MonoBehaviour
{
    public Vector2 mousePosition;
    public GameObject bullet;
    public Camera cam;

    public void Update()
    {
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bul = Instantiate(bullet, transform.position, transform.rotation);
            bul.GetComponent<bulletBehavior>().targetPosition = mousePosition;
        }



    }
}

