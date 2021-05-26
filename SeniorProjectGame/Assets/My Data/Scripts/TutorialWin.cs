using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialWin: MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
    float looking;
    float lookingDiff;

    bool playerIsLooking = false;

    void start()
    {
        playerIsLooking = false;
    }

    void Update()
    {
        if (playerIsLooking == true)
        {
            //Debug.Log("Player is Looking");
            LookedForOverOneSecond();
        }

        if (playerIsLooking == false)
        {
            //Debug.Log("Player is Not Looking");
        }

    }

    void OnDestroy()
    {
        SceneManager.LoadScene("OpenFeild");
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        playerIsLooking = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        looking = Time.time;
        playerIsLooking = true;
    }

    void LookedForOverOneSecond()
    {
        lookingDiff = Time.time - looking;
        if (lookingDiff > 1f)
        {
            Destroy(gameObject);
        }
    }

}
