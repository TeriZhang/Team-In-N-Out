using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDad : MonoBehaviour
{
    public float happiness;
    public float health;
    public float tidiness;
    // Start is called before the first frame update
    void Start()
    {
        happiness = 0;
        health = 100;
        tidiness = 100;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        health -= 0.36f * Time.fixedDeltaTime;
    }
}
