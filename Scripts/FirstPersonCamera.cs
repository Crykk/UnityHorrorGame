using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform player;

    public float mouseSens = 2f;

    private float cameraVerticalRotation = 0f;

    private bool lockedCursor = true;

    public bool state = true;
    
    // Start is called before the first frame update
    void Start()
    {
        //locks Mouse Cursor in the middle of the screen
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (state)
        {
            //Collect Mouse Input
            float inputX = Input.GetAxis("Mouse X")*Time.deltaTime*mouseSens;
            float inputY = Input.GetAxis("Mouse Y")*Time.deltaTime*mouseSens;
        
            //Rotate the Camera around its X axis
            cameraVerticalRotation -= inputY;
            cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
            transform.localEulerAngles = Vector3.right * cameraVerticalRotation;
        
            //Rotate the Player Object and the Camera around its Y axis
            player.Rotate(Vector3.up * inputX);
        }
        
        
        
    }
}
