using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public List<GameObject> target;
    public GameObject currentTarget;

    public bool Inzone;

    //Timer Related
    public float lastHit;
    public float hitCD;

    public GameObject gameDad;
    // Start is called before the first frame update
    void Start()
    {
        gameDad = GameObject.Find("GameManager");
        currentTarget = target[Random.Range(0, 6)];
        currentTarget.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        lastHit += Time.deltaTime;
        
        if(lastHit - hitCD >= 0)
        {
            lastHit = 0;
            currentTarget.gameObject.SetActive(false);
            currentTarget = target[Random.Range(0, 6)];
            currentTarget.gameObject.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Space) && Inzone == true)
        {
            currentTarget.gameObject.SetActive(false);
            Debug.Log("hit");
            gameDad.gameObject.GetComponent<GameDad>().addHappiness(5);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Inzone = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Inzone = false;
    }

}
