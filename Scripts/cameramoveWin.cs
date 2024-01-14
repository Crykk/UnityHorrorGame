using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameramoveWin : MonoBehaviour
{
    public float speed=0.2f;

    public GameObject _light;
    public GameObject sound;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject video;
    public GameObject menubutton;
    public GameObject text;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        text.SetActive(false);
        menubutton.SetActive(false);
        sound.SetActive(false);
        light1.SetActive(false);
        light2.SetActive(false);
        light3.SetActive(false);
        StartCoroutine(_lights());
        video.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        var light1pos = new Vector3(0, 2, 3);
        var i = new Vector3(0, 2, -11.5f);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position,i,step);
        if (transform.position == i)
        {
            StartCoroutine(win());
        }
    }

    IEnumerator win()
    {
        yield return new WaitForSeconds(2);
        sound.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        text.SetActive(true);
        menubutton.SetActive(true);
        _light.SetActive(true);
        yield return new WaitForSeconds(1);
        video.SetActive(true);
        
        
    }

    IEnumerator _lights()
    {
        yield return new WaitForSeconds(1f);
        light1.SetActive(true);
        yield return new WaitForSeconds(2f);
        light2.SetActive(true);
        yield return new WaitForSeconds(2f);
        light3.SetActive(true);
        
        
    }
    
}
