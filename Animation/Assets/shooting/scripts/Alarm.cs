using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    //4.39 + temp
    const float inspectPos = 4.5f;

    // Update is called once per frame
    void Update()
    {
        if (InfoManager.Instance.meteorPosY > inspectPos)
        {
            Vector3 trackingPos = new Vector3(InfoManager.Instance.player.transform.position.x, 2.7f, 0);
            transform.position = trackingPos;
        }
        else { Destroy(gameObject); }
    }
}
