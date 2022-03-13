using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingBed : MonoBehaviour
{
    public List<GameObject> bzs;

    public int currentBz;

    public GameObject gameDad;

    //Timer Related


    // Start is called before the first frame update
    void Start()
    {
        gameDad = GameObject.Find("GameManager");
        currentBz = 0;
        bzs[currentBz].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentBz += 1;
            bzs[currentBz].gameObject.SetActive(true);
            bzs[currentBz-1].gameObject.SetActive(false);
            gameDad.gameObject.GetComponent<GameDad>().addTidiness(5);
            gameDad.gameObject.GetComponent<GameDad>().RemoveIcon(3);
        }
    }
}
