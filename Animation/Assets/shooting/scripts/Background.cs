using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject[] background;

    private void FixedUpdate()
    {
        for(int i  = 0; i < background.Length; i++)
        {
            background[i].transform.position += Vector3.down * 5f * Time.deltaTime;
            if (background[i].transform.position.y < -8)
            {
                background[i].transform.position = new Vector3(0, 15.5f, 0);
            }
        }
    }
}
