using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateControl : MonoBehaviour
{
    //moving around
    public Rigidbody2D plateRb;
    public Vector2 velocity;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //Get RigidBody
        plateRb = gameObject.GetComponent<Rigidbody2D>();

        //Reset Velocity
        velocity = new Vector2(0, 0);
        speed = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        plateRb.MovePosition(plateRb.position + velocity * Time.deltaTime);
        //Cancel Movement Function
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            velocity = new Vector2(0, 0);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            velocity = new Vector2(0, 0);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            velocity = new Vector2(0, 0);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            velocity = new Vector2(0, 0);
        }
    }

    void FixedUpdate()
    {
        plateRb.MovePosition(plateRb.position + velocity * Time.fixedDeltaTime);
        //Movement Fuction
        if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity = new Vector2(0, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            velocity = new Vector2(0, -speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity = new Vector2(-speed, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity = new Vector2(speed, 0);
        }

    }

    
}
