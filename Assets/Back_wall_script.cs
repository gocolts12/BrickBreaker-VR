using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_wall_script : MonoBehaviour
{
    public GameObject brick;

    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        brick.active = true;
        //Debug.Log("Do something here");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Bricks to head")
        {
            //brick.SetActive(false);
            Destroy(collision.gameObject);
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("brick 1");
        }

        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == ball.name)
        {
           // brick.active = false;
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("ball 2");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
