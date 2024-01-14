using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteScript : MonoBehaviour
{
    public Transform player;
    //pickup note text
    [SerializeField] GameObject notetext;

    public bool state = false;
    [SerializeField] GameObject note;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player && state == false)
        {
            float dist = Vector3.Distance(player.position, transform.position);
            if (dist < 1.5f)
            {
                notetext.SetActive(true);
                if (Input.GetKey(KeyCode.E) && dist < 1.5f)
                {
                    state = true;
                    notetext.SetActive(false);
                    note.SetActive(true);
                    gameObject.SetActive(false);
                }
            }
            if (dist > 1.5f)
            {
                notetext.SetActive(false);
            }
        }
    }
}
