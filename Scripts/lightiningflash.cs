using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightiningflash : MonoBehaviour
{
    public float mintime = 0.5f;
    public float treshold = 0.5f;
    private float lastTime = 0f;
    public AudioSource _audio;
    public AudioClip clipp;
    
    

// Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        _audio.clip = clipp;
        _audio.Play();
        _audio.pitch = (Random.Range(0.6f, .9f));
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - lastTime) > mintime)
        {
            if (Random.value > treshold)
            {

                gameObject.GetComponent<Light>().enabled = true;
                lastTime = Time.time;
            }
        }
        else
        {
            gameObject.GetComponent<Light>().enabled = false;
        }
        
    } 
}