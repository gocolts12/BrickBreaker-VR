using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion_brick : MonoBehaviour
{
    public GameObject bricks;
    public GameObject bricks2;
    public ParticleSystem explode;

    public GameObject ball;

    Rigidbody rb;

    public Vector3 veloc;


    void Start()
    {
        //if(explode.isPlaying) explode.Stop();
        bricks.active = true;
        bricks2.active = true;

        rb = ball.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 5);
    }

    /* void OnTriggerEnter(Collider other)
     {
         if (!explode.isPlaying) {
             explode.Emit(100);
             //explode.Stop();
         }

         bricks.active = false;
         bricks2.active = false;
     }

     void OnTriggerExit(Collider other)
     {
         if (explode.isPlaying) explode.Stop();
     }*/

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == ball.name)
        {
            veloc = rb.velocity;
            //bricks.active = false;

            if (!explode.isPlaying)
            {
                explode.Emit(100);
                //explode.Stop();
            }

            Scoring.score += 1;
        }
    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log("Exit");
        //print("No longer in contact with " + other.transform.name);
        if (other.gameObject.name == ball.name)
        {
            bricks.active = false;
            bricks2.active = false;
            rb.velocity += veloc;

            //explode.Emit(100);
            //if (explode.isPlaying) explode.Stop();

            /* if (!explode.isPlaying)
             {
                 explode.Emit(100);
                 //explode.Stop();
             }*/

        }
    }
}
