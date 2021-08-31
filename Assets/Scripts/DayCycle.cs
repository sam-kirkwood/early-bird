using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DayCycle : MonoBehaviour
{
    public GameObject morning;
    public GameObject day;
    public GameObject night;

    // Start is called before the first frame update
    void Awake()
    {
        morning = GameObject.FindWithTag("morning");
        day = GameObject.FindWithTag("day");
        night = GameObject.FindWithTag("night");

        morning.GetComponent<SpriteRenderer>().enabled = false;
        day.GetComponent<SpriteRenderer>().enabled = false;
        night.GetComponent<SpriteRenderer>().enabled = false;


        // Morning:     6 - 8
        // Day:         9 - 17
        // Afternoon:   not yet implemented
        // Night:       18 - 5

        int hour = DateTime.Now.Hour;
        if(hour >= 6 && hour <= 8)
        {
           morning.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if(hour >= 9 && hour <= 17)
        {
           day.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if(hour >= 18 || hour <= 5)
        {
           night.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            Debug.Log("You fucked up?");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
