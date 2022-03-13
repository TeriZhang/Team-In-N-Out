using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wash : MonoBehaviour
{
    public List<GameObject> miniPlate;
    public GameObject currentMini;
    public bool selected;
    public bool controlable;

    public List<GameObject> bigPlate;
    public GameObject currentBig;
    public bool spawnable;

    public List<GameObject> redSelect;
    public GameObject currentSe;
    public int selectNum;

    public GameObject cover;
    public bool opened;

    public List<GameObject> inPlates;
    public int inAmount;

    public bool allIn;
    public bool noOverlap;
    public float Overlaped;

    // Start is called before the first frame update
    void Start()
    {
        opened = false;
        inAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (controlable == true)
        {
            currentBig.gameObject.GetComponent<PlateControl>().speed = 2f;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                currentBig.gameObject.GetComponent<PlateControl>().speed = 0;
                controlable = false;

            }
            

        }

        if (opened == true)
        {
            if(controlable == false)
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (selectNum >= 3)
                    {
                        selectNum = 3;
                    }
                    else
                    {
                        currentSe.SetActive(false);
                        selectNum += 1;
                        currentSe = redSelect[selectNum];
                        currentSe.SetActive(true);
                        spawnable = true;
                    }
                }

                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (selectNum <= 0)
                    {
                        selectNum = 0;
                    }
                    else
                    {
                        currentSe.SetActive(false);
                        selectNum -= 1;
                        currentSe = redSelect[selectNum];
                        currentSe.SetActive(true);
                        spawnable = true;
                    }
                }
            }
            
            if(spawnable == true)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    currentBig = bigPlate[selectNum];
                    currentBig.gameObject.SetActive(true);
                    controlable = true;
                    spawnable = false;
                    currentBig.gameObject.GetComponent<PlateControl>().speed = 2f;
                }
                
            }


            

            if (selected == true)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {                   
                   // currentBig.gameObject.GetComponent<PlateControl>().speed = 0;
                    //controlable = false;
                    //selected = false;
                    
                    
                }
                if(controlable == true)
                {
                   // currentBig.gameObject.GetComponent<PlateControl>().speed = 2f;
                    //spawnable = false;
                }
                

            }

            if (selected == false)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if(spawnable == true)
                    {
                        //currentBig = bigPlate[selectNum];
                        //currentBig.gameObject.SetActive(true);
                    }

                    //opened = false;
                    //selected = true;
                    //controlable = true;
                }
            }


            
        }

        // if Controlable, the object is able to move
        

        //Start Mini Game
        if (opened == false)
        {
            //1st Space, open the cover and show the selected box.
            if (Input.GetKeyDown(KeyCode.Space))
            {
                opened = true;
                cover.gameObject.SetActive(false);
                
                
                currentSe = redSelect[selectNum];
                currentSe.SetActive(true);
            }
        }

        if(inPlates[1] != null && inPlates[2] != null && inPlates[3] != null && inPlates[0] != null)
        {
            allIn = true;
        }

        if(Overlaped > 0)
        {
            noOverlap = false;
        }

        if(Overlaped == 0)
        {
            noOverlap = true;
        }

        //Win Here
        if(noOverlap == true && allIn == true)
        {
            Debug.Log("Win Wash");
        }

        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Plate"))
        {
            inPlates[inAmount] = other.gameObject;
            inAmount += 1;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Plate"))
        {
            inPlates[inAmount] = null;
            inAmount -= 1;
            if(inAmount <= 0)
            {
                inAmount = 0;
            }
        }
    }

    public void OverLap()
    {
        Overlaped += 1;
    }

    public void NoOverLap()
    {
        Overlaped -= 1;
    }

}
