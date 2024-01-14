using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInteract : MonoBehaviour
{
    public float mouseSens = 0.5f;

    private float cameraVerticalRotation;
    private float cameraHorizontalRotation;
    public GameObject button;
    public float speed = 1;
    

    public bool state = true;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        Menumouse();

    }

    void Menumouse()
    {
        float inputX = Input.GetAxis("Mouse X")*Time.deltaTime*mouseSens;
        float inputY = Input.GetAxis("Mouse Y")*Time.deltaTime*mouseSens;
        
        //make values negative
        cameraVerticalRotation -= inputY;
        cameraHorizontalRotation -= inputX;
        //limit camera rotation in menu to one degree
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, 19f, 20f);
        cameraHorizontalRotation = Mathf.Clamp(cameraHorizontalRotation, -20f, -19f);
        //rotate camera based on mouse input 
        transform.localRotation = Quaternion.Euler(cameraVerticalRotation,cameraHorizontalRotation,0);
    }
}
