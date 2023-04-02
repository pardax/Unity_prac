using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorManager : MonoBehaviour
{
    public GameObject meteorPrefab;
    public GameObject alarmPrefab;

    // player can inspect meteor pos at y == 4.39
    const float startingPos = 12f;

    void Start()
    {
        StartCoroutine(CreateMeteor());
    }
    

    IEnumerator CreateMeteor()
    {
        yield return new WaitForSeconds(5f);
        Instantiate(meteorPrefab, new Vector2(0, startingPos), Quaternion.identity);
        Instantiate(alarmPrefab);
        StartCoroutine(CreateMeteor());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
