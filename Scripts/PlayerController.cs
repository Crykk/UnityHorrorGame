using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float verticalInput;
    public float speed = 2;
    public Rigidbody playerRB;
    public bool state = true;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       PlayerControls(); 
    }

    void PlayerControls()
    {
        if (state)
        {
            //sprinting control
            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = 5;
            } else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                speed = 1;
            }
        
            // walking in all directions
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward*speed*Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back*speed*Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left*speed*Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right*speed*Time.deltaTime);
            } 
        }
    }

    
}
