using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cInput : MonoBehaviour
{
    public InputField input;

    public void InputChange()
    {
        Debug.Log(input.text);
    }

    public void InputEnd()
    {
        Debug.Log(input.text + "입력완료");
    }

}
