using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mosntercontrol : MonoBehaviour
{
    public bool state = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (state)
        {
            gameObject.transform.Translate(Vector3.forward * 10f * Time.deltaTime);
        }
    }
}
