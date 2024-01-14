using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backtoMenu : MonoBehaviour
{
    FlickerControl flicker1;
    FlickerControl flicker2;
    public GameObject light1;
    public GameObject light2;
    public Camera cam1;

    public Camera cam2;

    private void Start()
    {
        flicker1 = light1.GetComponent<FlickerControl>();
        flicker2 = light2.GetComponent<FlickerControl>();
    }

    public void change()
    {
        flicker1.state = !flicker1.state;
        flicker2.state = !flicker2.state;
        cam1.enabled = !cam1.enabled;
        cam2.enabled = !cam2.enabled;
    }
}
