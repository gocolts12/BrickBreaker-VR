using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks_To_Head_Script : MonoBehaviour
{
    public GameObject bricks;
    public GameObject ball;

    Rigidbody rball;
    Rigidbody rbrick;

    public Vector3 veloc;

    // Start is called before the first frame update
    void Start()
    {
        rball = ball.GetComponent<Rigidbody>();
        rball.velocity = new Vector3(0, 0, 5);

        rbrick = bricks.GetComponent<Rigidbody>();

    }

   /* void OnTriggerEnter(Collider other)
    {
        //bricks.active = false;
        Scoring.score += 1;

        bricks.active = true;
        rb = GetComponent<Rigidbody>();

        //bricks.transform.Random.Range(-30, 30), 0, Space.Self);

        rb.velocity = new Vector3(0, 0, -5);
    }*/

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == ball.name)
        {
            veloc = rball.velocity;
            //bricks.active = false;
            Scoring.score += 1;
        }
    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log("Exit");
        //print("No longer in contact with " + other.transform.name);
        if (other.gameObject.name == ball.name)
        {
            //bricks.active = false;
            rball.velocity = veloc;
            rbrick.velocity = new Vector3(0, 0, -5);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
