using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableWhenWon : MonoBehaviour
{

    public GameObject reticleDisabled;

    // Start is called before the first frame update
    void Start()
    {
        reticleDisabled.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player").GetComponent<ScoreUpdate>().count == 10)
        {
            reticleDisabled.SetActive(false);
        }
    }
}
