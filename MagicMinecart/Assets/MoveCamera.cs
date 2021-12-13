using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform target;


    private void Update()
    {
        transform.position = new Vector2(transform.position.x, target.position.y);
    }

}
