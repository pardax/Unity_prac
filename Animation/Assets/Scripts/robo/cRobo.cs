using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cRobo : MonoBehaviour
{
    Animator anim;
    SpriteRenderer sprite;
    bool crouch = false;
    int life = 3;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        sprite = gameObject.GetComponent<SpriteRenderer>();
        anim.SetInteger("life", life);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            float h = Input.GetAxisRaw("Horizontal");
            transform.Translate(Vector3.right * h * 3 * Time.deltaTime);
            anim.SetFloat("Speed", 2f);

            if(h > 0) { sprite.flipX = false; }
            else { sprite.flipX = true; }
        }
        else
        {
            anim.SetFloat("Speed", 0f);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector3 (0, 250, 0));
            anim.SetTrigger("Jump");
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(Vector3.left * 5 * Time.deltaTime);
            anim.SetBool("Run", true);
            sprite.flipX = true; 
        }
        else if (Input.GetKey(KeyCode.X))
        {
            transform.Translate(Vector3.right * 5 * Time.deltaTime);
            anim.SetBool("Run", true);
            sprite.flipX = false;
        }
        else
        {
            anim.SetBool("Run", false);
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            if (crouch)
            {
                crouch = false;
                anim.SetBool("crouch", crouch);
            }
            else
            {
                crouch = true;
                anim.SetBool("crouch", crouch);
            }
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
           anim.SetInteger("life", --life);
        }

        // z x Run
        //c crouch
        // crouch 일때 c 입력시 idle
        // add player life = 3
        // push g , life -1
        //if life less then 1, robo is dead
    }
}
