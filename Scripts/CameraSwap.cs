using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    FlickerControl flicker1;
    FlickerControl flicker2;
    public GameObject light1;
    public GameObject light2;
    public Camera cam1;

    public Camera cam2;
    // Start is called before the first frame update
    private void Start()
    {
        flicker1 = light1.GetComponent<FlickerControl>();
        flicker2 = light2.GetComponent<FlickerControl>();
        flicker1.state = true;
        flicker2.state = false;
        cam1.enabled = true;
        cam2.enabled = false;
    }

    public void change()
    {
        flicker1.state = !flicker1.state;
        flicker2.state = !flicker2.state;
        cam1.enabled = !cam1.enabled;
        cam2.enabled = !cam2.enabled;
    }
}
