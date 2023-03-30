using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]   //immune delete component
public class cToolTip : MonoBehaviour
{
    //Attribute : add additional information on code
    [Tooltip("EA")]
    public int count = 5;
    [Tooltip("Job")]
    public string job = "Cooker";

    [Header("Character speed")]
    public float speed = 3.3f;
    [Header("Character power")]
    public float power = 55;

    [Range(0f, 10)]
    public float defence = 5;

    [SerializeField]
    private int value = 11;

    [HideInInspector]
    public string helmet = "Çï¸ä";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
