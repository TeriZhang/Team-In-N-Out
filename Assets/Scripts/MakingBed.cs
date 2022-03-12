using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingBed : MonoBehaviour
{
    public List<GameObject> bzs;

    public int currentBz;

    //Timer Related


    // Start is called before the first frame update
    void Start()
    {
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
        }
    }
}
