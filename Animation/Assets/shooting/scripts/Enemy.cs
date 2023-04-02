using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    int currentHP = 3;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * 3 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Missile"))
        {
            currentHP--;
            anim.SetTrigger("hit");
            //missile unable
            collision.gameObject.SetActive(false);
            if(currentHP <= 0)
            {
                InfoManager.Instance.MakeMoney(transform, Random.Range(0, 3));
                InfoManager.Instance.MakeHpPack(transform);
                InfoManager.Instance.score += 5;
                InfoManager.Instance.CreateEffect(transform);
                Destroy(gameObject);
            }
        }
    }
}
