using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cRabbit : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) 
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }
        if (Input.GetKey(KeyCode.F))
        {
            anim.SetTrigger("Hit");
        }
        if(Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Attack");
        }
    }
}
