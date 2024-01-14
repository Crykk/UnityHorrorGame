using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class scizoSound : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public bool state=false;
    public GameObject button;
    public GameObject ghostSound;
    public AudioSource sound;
    private GameObject note1;
    void Start()
    {
        note1 = GameObject.Find("note1Object");
        note1.SetActive(false);
        state = false;
        button = GameObject.Find("MailButton");
        button.SetActive(false);
        sound = ghostSound.GetComponent<AudioSource>();
        sound.playOnAwake = false;

    }

    // Update is called once per frame
    private void Update()
    {
        if (player&&state==false)
        {
            float dist = Vector3.Distance(player.position, transform.position);
            if (dist < 2f)
            {
                button.SetActive(true);
                if (Input.GetKey(KeyCode.E)&&dist<2)
                {
                    button.SetActive(false);
                    state = true;
                    sound.volume = 1;
                    sound.PlayDelayed(0.5f);
                    note1.SetActive(true);

                }
            }

            if (dist > 2f)
            {
                button.SetActive(false);
            }
        }
    }
}
