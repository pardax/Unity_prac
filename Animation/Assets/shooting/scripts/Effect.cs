using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    // * Animation Event
    public void EffectEnd()
    {
        Destroy(gameObject);
    }
}
