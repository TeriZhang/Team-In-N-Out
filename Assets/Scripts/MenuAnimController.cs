using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuAnimController : MonoBehaviour
{
    public List<GameObject> start;

    public int current;

    //Timer Related


    // Start is called before the first frame update
    void Start()
    {
        current = 0;
        start[current].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            current += 1;
            start[current].gameObject.SetActive(true);
            start[current - 1].gameObject.SetActive(false);
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void FromStart()
    {
        SceneManager.LoadScene(0);
    }




}
