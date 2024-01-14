using System;
using System.Collections;
using System.Collections.Generic;
using SojaExiles;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * ---------------------
 *  script by CRYK     │
 *     [GameManager]   │
 * ---------------------
 */
public class GameManagerScript : MonoBehaviour
{
    //all script references  
    scizoSound mailScript;
    ATM_interact ATMScript;
    PlayerController playerSpeed;
    FirstPersonCamera mouseLook;
    FlickerControl LightFlicker;
    NoteScript _noteScript;
    
    

    //all GameObject references
    [SerializeField] GameObject mailbox;

    [SerializeField] GameObject ATM;

    [SerializeField] GameObject mail;

    [SerializeField] GameObject atm;

    [SerializeField] GameObject notetext;

    [SerializeField] GameObject note1;

    [SerializeField] GameObject startNote;

    [SerializeField] GameObject player;

    [SerializeField] GameObject camera;

    [SerializeField] Text AtmText;

    [SerializeField] Text MailText;
    
    [SerializeField] AudioSource audio;
    
    [SerializeField] GameObject AudioGameObject;
    
    [SerializeField] GameObject note2;
    
    [SerializeField] GameObject note3;
    
    [SerializeField] Text LabyrintText;

    [SerializeField] GameObject note3object;
    
    

    // Start is called before the first frame update
    void Awake()
    {
        //reference all variables at the start of game
        _noteScript = note3object.GetComponent<NoteScript>();
        LabyrintText.text = "Complete Labyrint";
        note3.SetActive(false);
        note2.SetActive(false);
        startNote.SetActive(true);
        mouseLook = camera.GetComponent<FirstPersonCamera>();
        note1.SetActive(false);
        playerSpeed = player.GetComponent<PlayerController>();
        notetext.SetActive(false);
        ATMScript = ATM.GetComponent<ATM_interact>();
        mailScript = mailbox.GetComponent<scizoSound>();
        AtmText = atm.GetComponent<Text>();
        MailText = mail.GetComponent<Text>();
        AtmText.text = "Check Bank Balance";
        MailText.text = "Check Mailbox";
        MailText.color = Color.green;
        AtmText.color = Color.green;
        LabyrintText.color = Color.green;
        audio = AudioGameObject.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //calls all voids every second
        ATMCheck();
        MailCheck();
        Note1Check();
        StartNoteCheck();
        Note2Check();
        Note3Check();
        NoteCheck();
        youwin();


    }

    // void to check is ATM task completed
    void ATMCheck()
    {
        //checks if ATM task is completed and changes its text and color
        if (ATMScript.state)
        {
            AtmText.text = "C̶h̶e̶c̶k̶ ̶B̶a̶n̶k̶ ̶B̶a̶l̶a̶n̶c̶e̶";
            AtmText.color = Color.gray;
        }

        //checks if ATM task is NOT completed and changes its text
        if (ATMScript.state == false)
        {
            AtmText.text = "Check Bank Balance";
        }
    }

    // void to check is MAIL task completed
    void MailCheck()
    {
        //if mailbox task is completed change task text and color
        if (mailScript.state)
        {
            MailText.text = "C̶h̶e̶c̶k̶ ̶M̶a̶i̶l̶b̶o̶x̶";
            MailText.color = Color.gray;

        }

        //if mailbox task is NOT completed change task text
        if (mailScript.state == false)
        {
            MailText.text = "Check Mailbox";
        }
    }
    void NoteCheck()
    {
        //if mailbox task is completed change task text and color
        if (_noteScript.state)
        {
            LabyrintText.text = "C̶h̶e̶c̶k̶ ̶L̶a̶b̶y̶r̶i̶n̶t̶h̶";
            MailText.color = Color.gray;

        }

        //if mailbox task is NOT completed change task text
        if (_noteScript.state == false)
        {
            LabyrintText.text = "Check Labyrinth";
        }
    }

    void Note1Check()
    {
        //if the note image is active player cant move or look around until LMB is pressed
        if (note1.active)
        {
            mouseLook.state = false;
            Cursor.visible = true;
            audio.Play();
            Cursor.lockState = CursorLockMode.None;
            playerSpeed.state = false;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Cursor.visible = false;
                playerSpeed.state = true;
                Cursor.lockState = CursorLockMode.Locked;
                note1.SetActive(false);
                mouseLook.state = true;
            }

        }
    }
    void Note2Check()
    {
        //if the note image is active player cant move or look around until LMB is pressed
        if (note2.active)
        {
            mouseLook.state = false;
            Cursor.visible = true;
            audio.Play();
            Cursor.lockState = CursorLockMode.None;
            playerSpeed.state = false;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Cursor.visible = false;
                playerSpeed.state = true;
                Cursor.lockState = CursorLockMode.Locked;
                note2.SetActive(false);
                mouseLook.state = true;
            }

        }
    }
    void Note3Check()
    {
        //if the note image is active player cant move or look around until LMB is pressed
        if (note3.active)
        {
            mouseLook.state = false;
            Cursor.visible = true;
            audio.Play();
            Cursor.lockState = CursorLockMode.None;
            playerSpeed.state = false;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Cursor.visible = false;
                playerSpeed.state = true;
                Cursor.lockState = CursorLockMode.Locked;
                note3.SetActive(false);
                mouseLook.state = true;
            }

        }
    }


    void StartNoteCheck()
    {
        if (startNote.active)
        {
            audio.Play();
            mouseLook.state = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            playerSpeed.state = false;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Cursor.visible = false;
                playerSpeed.state = true;
                Cursor.lockState = CursorLockMode.Locked;
                startNote.SetActive(false);
                mouseLook.state = true;
            }
        }
    }

    void youwin()
    {
        if (ATMScript.state&&mailScript.state&&_noteScript.state)
        {
            StartCoroutine(win());
        }
    }

    IEnumerator win()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("WinningScene");
    }
}
