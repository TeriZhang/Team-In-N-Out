using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Slider slider;

    public GameObject gameManager;
    
    //hapi 1 health 2 tidi 3
    public float stateNum;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = gameManager.gameObject.GetComponent<GameDad>().health;
    }
}
