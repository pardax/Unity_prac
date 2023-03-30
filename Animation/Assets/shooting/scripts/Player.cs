using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal")) {
            float h = Input.GetAxisRaw("Horizontal");

            transform.Translate(Vector3.right * h * 3f * Time.deltaTime);

            Vector3 myPos = transform.position;
            
            // if value are less then min, return min
            // if value are bigger then max, return max
            myPos.x = Mathf.Clamp(transform.position.x, -2f, 2);
            transform.position = myPos;
        }
    }
}
