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

    // Start is called before the first frame update
    void Start()
    {
        opened = false;
    }

    // Update is called once per frame
    void Update()
    {
        
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
                }
                
            }


            if(controlable == true)
            {
                currentBig.gameObject.GetComponent<PlateControl>().speed = 2f;
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

        else if (controlable == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                controlable = false;
            }
        }

        
    }
}
