using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDad : MonoBehaviour
{
    public float happiness;
    public float health;
    public float tidiness;
    public float totaltimer;

    

    public List<GameObject> Warning;
    // Start is called before the first frame update
    void Start()
    {
        
        Warning[0].gameObject.SetActive(true);
        

        happiness = 0;
        health = 100;
        tidiness = 100;

    }

    // Update is called once per frame
    void Update()
    {
        totaltimer = Time.time;
        if (totaltimer > 300)
        {
            SceneManager.LoadScene(4);
        }
        if (tidiness <= 0)
        {
            SceneManager.LoadScene(2);
        }
        if (health <= 0)
        {
            SceneManager.LoadScene(3);
        }
        //
        if (happiness >= 25)
        {
            Warning[1].gameObject.SetActive(true);
        }

        if (happiness > 50 && happiness < 75)
        {
            Warning[2].gameObject.SetActive(true);
            Warning[3].gameObject.SetActive(true);
        }

        if ( happiness >= 75 && happiness < 100)
        {
            Warning[4].gameObject.SetActive(true);
        }

        if(happiness >= 100)
        {
            SceneManager.LoadScene(5);
        }

        if(tidiness > 100)
        {
            tidiness = 100;
        }
    }

    private void FixedUpdate()
    {
        health -= 0.36f * Time.fixedDeltaTime;
        tidiness -= 0.5f * Time.fixedDeltaTime;
    }

    public void losetidiness()
    {
        tidiness -= 30;
    }

    public void addHappiness(int number)
    {
        happiness += 5;
    }

    public void addTidiness(int number)
    {
        tidiness += 30;
    }

    public void addHealth()
    {
        health = 100;
    }

    public void RemoveIcon(int number)
    {
        Warning[number].gameObject.SetActive(false);
    }
}
