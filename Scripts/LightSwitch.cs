using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class LightSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public bool lightState;
    public Transform player;
    //public GameObject[] lights;
    public GameObject[] lights;
    void Start()
    {
        lightState = true;
        lights = GameObject.FindGameObjectsWithTag("street_light");
    }

  
    // Update is called once per frame
    private void OnMouseOver()
    {
        if (player)
        {
            float dist = Vector3.Distance(player.position, transform.position);
            if (dist < 15)
            {

                    if (Input.GetMouseButtonDown(0))
                    {
                        switch (lightState)
                        {
                            case true:
                                foreach (var l in lights)
                                {
                                    l.gameObject.SetActive(false);
                                }
                                lightState = false;
                                break;
                            case false:
                                foreach (var l in lights)
                                {
                                    l.gameObject.SetActive(true);
                                }
                                lightState = true;
                                break;
                        }
                    }
            }

        }
    }
}