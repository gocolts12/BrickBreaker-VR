using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle_ball_script : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject ball;
    public Vector3 veloc;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = ball.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 5);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == ball.name)
        {
            veloc = rb.velocity;
            Debug.Log("ball collision");
            audioSource.Play();
        }

    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log("Exit");
        //print("No longer in contact with " + other.transform.name);
        if (other.gameObject.name == ball.name)
        {
            //veloc.x *= (float)1.025;
            //veloc.y *= (float)1.025;
            //veloc.z *= (float)1.025;
            //rb.velocity += veloc*3;

        }
    }
}
