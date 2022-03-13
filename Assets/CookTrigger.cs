using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookTrigger : MonoBehaviour
{
    public GameObject CookMiniGame;

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
                CookMiniGame.gameObject.SetActive(true);
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
        CookMiniGame.gameObject.SetActive(false);
    }
}
