using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cButton : MonoBehaviour
{
    public GameObject obj;

    public void ButtonEvent()
    {
        if (obj.activeSelf
            )
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);
        }

        Debug.Log("Click Btn");
    }
}
