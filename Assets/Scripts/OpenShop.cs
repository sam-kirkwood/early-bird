using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenShop : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMorningClick()
    {
        SceneManager.LoadScene("MorningScene");
    }

    public void OnDayClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

        public void OnNightClick()
    {
        SceneManager.LoadScene("NightScene");
    }
}
