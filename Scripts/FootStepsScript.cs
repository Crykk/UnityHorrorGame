using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * ---------------------
 *  script by CRYK     │
 *     [footsteps]     │
 * ---------------------
 */
public class FootStepsScript : MonoBehaviour
{
    public GameObject footstep;
    private bool playAudio = true;
    private bool state;

    // Start is called before the first frame update
    void Start()
    {
        //assigns all values
        footstep.SetActive(false);
        var position = gameObject.transform.position;
        footstep.transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        FootStepControl();
        footstep.transform.position = gameObject.transform.position;
    }
    
    void FootStepControl()
    {
        // plays footstep sound if player moves
        if (Input.GetKey(KeyCode.W))
        {
            footsteps(footState: true);
        }else if (Input.GetKeyUp(KeyCode.W))
        {
            footsteps(footState: false);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            footsteps(footState: true);
        }else if (Input.GetKeyUp(KeyCode.S))
        {
            footsteps(footState: false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            footsteps(footState: true);
        }else if (Input.GetKeyUp(KeyCode.A))
        {
            footsteps(footState: false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            footsteps(footState: true);
        } else if (Input.GetKeyUp(KeyCode.D))
        {
            footsteps(footState: false); 
        }
        
    }
   //this void sets audio to active state or deactivates it
    void footsteps(bool footState = true)
    {
        //footstep is an audiosource gameObject
        footstep.SetActive(footState);
    }
}
