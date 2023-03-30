using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{

    
    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(BulletEnd());
    }

    IEnumerator BulletEnd()
    {
        yield return new WaitForSeconds(10f);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * 5f * Time.deltaTime);

    }
}
