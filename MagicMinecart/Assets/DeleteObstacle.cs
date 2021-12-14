using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObstacle : MonoBehaviour
{
    private void Update()
    {
        Transform deleteObstaclePos = GameObject.Find("DeleteObstacle").GetComponent<Transform>();

        if (transform.position.y < deleteObstaclePos.position.y) Destroy(gameObject);
    }
}
