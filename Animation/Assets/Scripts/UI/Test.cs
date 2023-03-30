using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    Image img;
    float count = 0;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    private void Update()
    {
        img.fillAmount = count;
        count += 0.01f * Time.deltaTime;
    }


}
