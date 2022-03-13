using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cook : MonoBehaviour
{
    public List<GameObject> Recipe;
    public List<GameObject> RandomFood;
    public int NumRandomFood;
    public int FoodNum;
    public int storedRandomFood;
    public GameObject currentRecipe;
    public GameObject currentRandomFood;

    public List<int> usedFood;
    public List<GameObject> randomRecipe;
    public int tries;

    public List<GameObject> food;
    public GameObject currentFd;

    public List<GameObject> redSelect;
    public GameObject currentSe;
    public int selectNum;

    public bool spawnable;

    public GameObject gameDad;

    // Start is called before the first frame update
    void Start()
    {
        gameDad = GameObject.Find("GameManager");
        tries = 0;

        currentSe = redSelect[selectNum];
        currentSe.SetActive(true);

        spawnable = true;
        NumRandomFood = 0;

        RecipeLoop();
    }

    // Update is called once per frame
    void Update()
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
        else if (Input.GetKeyDown(KeyCode.UpArrow))
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

        if (spawnable == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartCoroutine(FoodFall());
                spawnable = false;
                if (usedFood[0] == 0 && usedFood[1] == 0 && usedFood[2] == 0 && usedFood[3] == 0)
                {
                    Debug.Log("Allin");
                    gameDad.gameObject.GetComponent<GameDad>().addHealth();
                    gameDad.gameObject.GetComponent<GameDad>().RemoveIcon(2);
                }
            }

        }

        
    }

    private void RecipeLoop()
    {     
        for (int FoodNum = 0; FoodNum < 4; FoodNum++)
        {
            //
            currentRecipe = Recipe[FoodNum];
            
            
            currentRandomFood = RandomFood[NumRandomFood];
            randomRecipe[FoodNum] = RandomFood[NumRandomFood];
            currentRandomFood.transform.position = currentRecipe.transform.position;
            currentRandomFood.SetActive(true);
            NumRandomFood += 1;

        }
    }

    IEnumerator FoodFall()
    {
        
            currentFd = food[selectNum];
            currentFd.gameObject.SetActive(true);

        usedFood[selectNum] = 0;

            yield return new WaitForSeconds(0.5f);

            currentFd.gameObject.SetActive(false);
            currentFd.transform.position = new Vector3(3.55f, 1.99f, -0.68f);
           
        
        
    }


}
