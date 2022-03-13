using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Books : MonoBehaviour
{
    public List<GameObject> signs;
    public GameObject currentSign;
    //0 yuan 1 fang 2 cha 3 sanjiao

    public List<GameObject> books;
    public GameObject bottomBook;
    public int bookNum;
    // Start is called before the first frame update
    void Start()
    {
        currentSign = signs[Random.Range(0, 4)];
        currentSign.SetActive(true);

        bookNum = 7;
        bottomBook = books[bookNum];
    }

    // Update is called once per frame
    void Update()
    {
        //Square
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(currentSign == signs[1])
            {
                Debug.Log("uright");

                currentSign.SetActive(false);
                currentSign = signs[Random.Range(0, 4)];
                currentSign.SetActive(true);

                
                bottomBook.SetActive(false);

                bookNum -= 1;
                bottomBook = books[bookNum];
                bottomBook.SetActive(true);
            }
            else
            {
                Debug.Log("uwrong");
            }
        }

        //Circle
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentSign == signs[0])
            {
                Debug.Log("uright");

                currentSign.SetActive(false);
                currentSign = signs[Random.Range(0, 4)];
                currentSign.SetActive(true);

                
                bottomBook.SetActive(false);

                bookNum -= 1;
                bottomBook = books[bookNum];
                bottomBook.SetActive(true);
            }
            else
            {
                Debug.Log("uwrong");
                
            }
        }

        //Cross
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentSign == signs[2])
            {
                Debug.Log("uright");

                currentSign.SetActive(false);
                currentSign = signs[Random.Range(0, 4)];
                currentSign.SetActive(true);

                
                bottomBook.SetActive(false);
                
                bookNum -= 1;
                bottomBook = books[bookNum];
                bottomBook.SetActive(true);
            }
            else
            {
                Debug.Log("uwrong");
                
            }
        }

        //Cross
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (currentSign == signs[3])
            {
                Debug.Log("uright");

                currentSign.SetActive(false);
                currentSign = signs[Random.Range(0, 4)];
                currentSign.SetActive(true);

                
                bottomBook.SetActive(false);
                
                bookNum -= 1;
                bottomBook = books[bookNum];
                bottomBook.SetActive(true);
            }
            else
            {
                Debug.Log("uwrong");
                
            }
        }

        if(bookNum < 0)
        {
            currentSign.SetActive(false);
        }
    }


}
