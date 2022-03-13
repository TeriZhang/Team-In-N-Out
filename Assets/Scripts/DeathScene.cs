using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScene : MonoBehaviour
{
    public GameObject Scene;
    
    // Start is called before the first frame update
    void Start()
    {
        Scene.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Scene.SetActive(true);
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(0);
    }
}
