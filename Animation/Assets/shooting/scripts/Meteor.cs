using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meteor : MonoBehaviour
{
    const float inspectPos = 4.39f;

    void Start()
    {
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * 3 * Time.deltaTime);
        if(transform.position.y > inspectPos)
        {
            Vector3 trackingPos = new Vector3(InfoManager.Instance.player.transform.position.x, transform.position.y, 0);
            InfoManager.Instance.SetMetorPos(transform.position.y);
            transform.position = trackingPos;
        }
    }
}
