using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cImage : MonoBehaviour
{
    Image img;
    float waitTime = 5f;

    float currentHp = 90f;
    float maxHp = 100f;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();    
    }

    // Update is called once per frame
    private void Update()
    {
        CoolDown();
    }

    void HpReduce()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            currentHp--;
            img.fillAmount = currentHp / maxHp;
        }
    }

    void CoolDown()
    {
        img.fillAmount -= 1.0f / waitTime * Time.deltaTime;
    }
}
