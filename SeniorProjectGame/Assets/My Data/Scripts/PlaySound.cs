using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player").GetComponent<ScoreUpdate>().count == 10)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
