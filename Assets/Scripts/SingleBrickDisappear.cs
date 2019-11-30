using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleBrickDisappear : MonoBehaviour
{
    public GameObject bricks;
    public GameObject ball;

    Rigidbody rb;

    public Vector3 veloc;

    public AudioSource audioSource;

    void Start()
    {
        rb = ball.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 5);
        
        bricks.active = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == ball.name)
        {
            //double newX, newY, newZ = 0;
            veloc = rb.velocity;
            //veloc.x = veloc.x * (float)1.1;
            //bricks.active = false;
            Scoring.score += 1;
            audioSource.Play();
        }
    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log("Exit");
        //print("No longer in contact with " + other.transform.name);
        if (other.gameObject.name == ball.name)
        {
            //veloc.x *= (float)1.1;
            //veloc.y *= (float)1.1;
            //veloc.z *= (float)1.1;
            bricks.active = false;
            rb.velocity = veloc;
            
        }
    }

}
