using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject bullet;
    public Transform rot;


    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, transform.position, rot.rotation);
        }
    }




}
