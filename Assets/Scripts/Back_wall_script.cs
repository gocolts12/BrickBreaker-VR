using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_wall_script : MonoBehaviour
{
    public GameObject brick;

    public GameObject ball;

    Rigidbody rb;

    public Vector3 veloc;

    public Vector3 temp;

    public AudioSource audioSource;

    public GameObject gameOver;

    public GameObject sound;

    public GameObject lifesound;

    // Start is called before the first frame update
    void Start()
    {
        rb = ball.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 5);

        brick.SetActive(true);
        //Debug.Log("Do something here");

        gameOver.SetActive(false);
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
            //veloc = rb.velocity;
            audioSource.Play();
            Debug.Log("ball 2");
            Lives.lives -= 1;
            lifesound.SetActive(true);
            if (Lives.lives <= 0) {
                rb.velocity = new Vector3(0, 0, 0);
                sound.SetActive(false);
                gameOver.SetActive(true);
            }
        }

    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log("Exit");
        //print("No longer in contact with " + other.transform.name);
        if (other.gameObject.name == ball.name)
        {
            /*temp = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z + 1);
            rb.velocity = temp;*/
            lifesound.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
