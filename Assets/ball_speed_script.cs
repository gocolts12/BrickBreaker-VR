using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_speed_script : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject ball;
    float constantSpeed = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = constantSpeed * (rb.velocity.normalized);
        ////give a constant acceleration
        //if (rb.velocity.magnitude > 10)
        //    rb.velocity = rb.velocity.normalized * 10;
        //else if (rb.velocity.magnitude < 10)
        //    rb.velocity = rb.velocity.normalized * 10;
    }
}
