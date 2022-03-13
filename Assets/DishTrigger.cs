using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishTrigger : MonoBehaviour
{
    public GameObject DishMiniGame;

    private bool gameStart;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (gameStart == true)
            {
                DishMiniGame.gameObject.SetActive(true);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log(1232132131);
        gameStart = true;

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        gameStart = false;
        DishMiniGame.gameObject.SetActive(false);
    }
}
