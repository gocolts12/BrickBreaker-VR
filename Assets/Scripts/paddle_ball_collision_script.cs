using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle_ball_script : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
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
            Debug.Log("ball collision");
            audioSource.Play();
        }

    }
}
