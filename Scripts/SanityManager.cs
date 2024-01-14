using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SanityManager : MonoBehaviour
{
    // assigning variables
    public Text timerText;
    public int levels = 100;
    public bool takingAwayLevels = false;
    public GameObject screamer;
    void Start()
    {
        //set timer text on start
        timerText.text = "TIME LIMIT: " + levels.ToString("0");
        screamer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (takingAwayLevels == false && levels > 0)
        {
            //calls coroutine that sets timer and starts it
            StartCoroutine(SanityLevelDuration());
        }

        if (levels <= 0)
        {
            StartCoroutine(Death());
        }
    }
    
    IEnumerator SanityLevelDuration()
    {
        //logic of timer
        takingAwayLevels = true;
        yield return new WaitForSeconds(2f);
        levels = levels - 1;
        timerText.text = "TIME LIMIT: " + levels.ToString("0");
        takingAwayLevels = false;
    }

    IEnumerator Death()
    {   
        screamer.SetActive(true);
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene("LosingScene");

    }
}
