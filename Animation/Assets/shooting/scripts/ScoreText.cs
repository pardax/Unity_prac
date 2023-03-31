using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    TextMeshProUGUI text;
    int tempScore;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(tempScore != InfoManager.Instance.score)
        {
            tempScore = InfoManager.Instance.score;
            this.text.text = tempScore.ToString();
        }
    }
}
