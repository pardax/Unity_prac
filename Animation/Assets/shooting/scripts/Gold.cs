using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        rb.AddForce(new Vector2(Random.Range(-50, 50), Random.Range(200, 300)));
        StartCoroutine(GoldEnd());
    }

    IEnumerator GoldEnd()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            InfoManager.Instance.score += 10;
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 myPos = transform.position;
        if(myPos.x <= -2)
        {
            rb.AddForce(new Vector2(50,0));
        }else if (myPos.x >= 2)
        {
            rb.AddForce(new Vector2(-50, 0));
        }
    }
}
