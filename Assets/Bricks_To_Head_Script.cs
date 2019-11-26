using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks_To_Head_Script : MonoBehaviour
{
    public GameObject bricks;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {


    }

    void OnTriggerEnter(Collider other)
    {
        //bricks.active = false;
        Scoring.score += 1;

        bricks.active = true;
        rb = GetComponent<Rigidbody>();

        //bricks.transform.Random.Range(-30, 30), 0, Space.Self);

        rb.velocity = new Vector3(0, 0, -5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
