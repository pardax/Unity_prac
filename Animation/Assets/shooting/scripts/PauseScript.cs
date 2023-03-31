using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    bool pauseSwtich = false;

    public void OnClickPauseButton()
    {
        if (pauseSwtich) { Time.timeScale = 1f; pauseSwtich = !pauseSwtich; }
        else { Time.timeScale = 0f; pauseSwtich = !pauseSwtich; }
    }
}
