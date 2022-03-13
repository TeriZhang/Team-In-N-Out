using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverLapCheck : MonoBehaviour
{
    public GameObject wash;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlateCheck"))
        {
            wash.gameObject.GetComponent<Wash>().OverLap();
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlateCheck"))
        {
            wash.gameObject.GetComponent<Wash>().NoOverLap();
            
        }
    }
}
