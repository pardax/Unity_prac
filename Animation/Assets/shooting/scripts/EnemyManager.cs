using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemy_bug, enemy_fairy;

    float posX = -2f;
    float posY = 6f;

    void Start()
    {
        StartCoroutine(CreateEnemy());
    }

    IEnumerator CreateEnemy()
    {
        for(int i = 0; i < 5; i++)
        {
            if(Random.Range(0, 2) == 0) { Instantiate(enemy_bug
                , new Vector3(posX + i, posY, 0), Quaternion.identity); }
            else { Instantiate(enemy_fairy, new Vector3(posX + i, posY, 0), Quaternion.identity); }
        }
        yield return new WaitForSeconds(2.5f);
        StartCoroutine(CreateEnemy());
    }
}
