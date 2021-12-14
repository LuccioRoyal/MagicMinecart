using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithObstacle : MonoBehaviour
{
    private SceneController sceneController;
    [SerializeField] LayerMask collisionMask;

    private void Start()
    {
        if (GameObject.Find("SceneManageObject") != null) sceneController = GameObject.Find("SceneManageObject").GetComponent<SceneController>();
    }

    private void Update()
    {
        if (Physics2D.OverlapCircle(transform.position, 0.5f, collisionMask)) sceneController.LoadThisScene("TitleScreen");
    }
}
