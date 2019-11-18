using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleBrickDisappear : MonoBehaviour
{
    public GameObject bricks;

    void Start()
    {
        bricks = GameObject.Find("brick");

        bricks.active = true;
    }

    void OnTriggerEnter(Collider other)
    {
        bricks.active = false;
    }

}
