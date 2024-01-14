using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 *  Light Flicker Control
 *  By Cryk                 
 */
public class FlickerControl : MonoBehaviour
{
    public bool isFlickering = false;
    private float timeDelay;
    public bool state = false;
    void Update()
    {
        if (isFlickering == false && state)
        {
            StartCoroutine(FlickeringLight());
        }

    }

    IEnumerator FlickeringLight()
    {
        isFlickering = true;
        gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(0.01f, 0.7f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;

    }
}
