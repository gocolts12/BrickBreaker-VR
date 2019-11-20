using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion_brick : MonoBehaviour
{
    public GameObject bricks;
    public GameObject bricks2;
    public ParticleSystem explode;


    void Start()
    {
        if(explode.isPlaying) explode.Stop();
        bricks.active = true;
        bricks2.active = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (!explode.isPlaying) {
            explode.Play();
            //explode.Stop();
        }

        bricks.active = false;
        bricks2.active = false;
    }

    void OnTriggerExit(Collider other)
    {
        if (explode.isPlaying) explode.Stop();
    }
}
