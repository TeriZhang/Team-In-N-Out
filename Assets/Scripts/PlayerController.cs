using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //moving around
    public Rigidbody2D playerRb;
    public Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        //Get RigidBody
        playerRb = gameObject.GetComponent<Rigidbody2D>();

        //Reset Velocity
        velocity = new Vector2(0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        playerRb.MovePosition(playerRb.position + velocity * Time.deltaTime);
        //Cancel Movement Function
        if (Input.GetKeyUp(KeyCode.W))
        {
            velocity = new Vector2(0, 0);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            velocity = new Vector2(0, 0);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            velocity = new Vector2(0, 0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            velocity = new Vector2(0, 0);
        }
    }

    void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + velocity * Time.fixedDeltaTime);
        //Movement Fuction
        if (Input.GetKey(KeyCode.W))
        {
            velocity = new Vector2(0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity = new Vector2(0, -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity = new Vector2(-1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity = new Vector2(1, 0);
        }

    }
}
