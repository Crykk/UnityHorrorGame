using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATM_interact : MonoBehaviour
{
    //Define all variables
    public bool state = false;
    public Transform player;
    public GameObject screen;
    private AudioSource sound;
    public GameObject text;
    public GameObject _light;
    public GameObject ATMsteertLight;
    FlickerControl lightcontrol;
    public GameObject noteLight;
    public GameObject note2;

    void Start()
    {
        // define all variables and set all values at the start
        note2 = GameObject.Find("note2Object");
        note2.SetActive(false);
        noteLight = GameObject.Find("note2Lamp");
        noteLight.SetActive(false);
        ATMsteertLight = GameObject.Find("ATMstreetLight");
        state = false;
        screen.SetActive(false);
        sound = gameObject.GetComponent<AudioSource>();
        text = GameObject.Find("ATM_button");
        sound.playOnAwake = false;
        _light = GameObject.Find("ATM_light");
        _light.SetActive(true);
        lightcontrol = ATMsteertLight.GetComponent<FlickerControl>();
    }

    // Update calls ATMvoid void every second
    void Update()
    {
        ATMvoid();
    }
    
    
    void ATMvoid()
    {
        //checks for player transfrom and checks state variable for its state
        if (player && state == false)
        {
            //dist is players position
            float dist = Vector3.Distance(player.position, transform.position);
            //if players position to this gameobject is lower than 2 you can interact with ATM
            if (dist < 2)
            {
                text.SetActive(true);
                if (Input.GetKey(KeyCode.E) && dist < 2)
                {
                    //if you interact with ATM task will be completed and you get note
                    lightcontrol.state = true;
                    _light.SetActive(false);
                    text.SetActive(false);
                    screen.SetActive(true);
                    StartCoroutine(LightChange());
                    StartCoroutine(notespawn());
                    sound.PlayDelayed(18);
                }
            }
            //if you are away from atm text will be not displayed
            if (dist > 2)
            {
                text.SetActive(false);

            }
        }
    }

    IEnumerator LightChange()
    {
        //when ATM video endsthis happens:
         var i = GameObject.Find("ATMHIGHLIGHT");
         yield return new WaitForSeconds(18);
         //street light starts to flicker
         ATMsteertLight.SetActive(false);
         // atm light turns red
        i.GetComponent<Light>().color = Color.red;
        yield return new WaitForSeconds(2);
        state = true;

    }

    IEnumerator notespawn()
    {
        //when ATM video ends this happens:
        yield return new WaitForSeconds(16);
        //light on top of note lights up
        noteLight.SetActive(true);
        //note turns visible and interactible
        note2.SetActive(true);
    }
    // i use void Awake because it runs first and i want stuff below happen first
    private void Awake()
    {
        // find and set ATM video 
        screen = GameObject.Find("ATM_screen");
    }
}


