using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TMP : MonoBehaviour
{
    public TMP_Text txt;
    public GameObject obj;


    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<TextMeshProUGUI>();
        txt.SetText("��ũ��Ʈ�� ����� �ؽ�Ʈ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
