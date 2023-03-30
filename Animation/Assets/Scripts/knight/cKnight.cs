using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cKnight : MonoBehaviour
{
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(h, v);
            transform.Translate(movement.normalized * 3 * Time.deltaTime);
            anim.SetBool("isMove", true);
            anim.SetFloat("posX", h);
            anim.SetFloat("posY", v);


        }
        else
        {
            anim.SetBool("isMove", false);
        }
    }
}
