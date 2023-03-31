using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    int num = 5;

    // Start is called before the first frame update
    void Start()
    {
        num++;
        num++;
        num++;
        num--;
        num--;
        num--;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
