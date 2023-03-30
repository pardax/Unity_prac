using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cText : MonoBehaviour
{
    public Text txt;
    int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        txt.fontSize = 50;
        txt.text = string.Format("score : {0}", score); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) 
        { 
            score++;
            txt.text = string.Format("score : {0}", score);
            if(score % 2 == 1)
            {
                txt.color = Color.red;
            }
            else
            {
                txt.color = Color.blue;
            }

        }
    }
}
