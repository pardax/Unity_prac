using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileProcess : MonoBehaviour
{
    // 오브젝트 풀 // 디자인 패턴 종류 중 하나
    // 오브젝트 재활용하는 패턴

    public GameObject missile;
    public List<GameObject> missilePool = new List<GameObject>();

    GameObject memoryPools;

    float interval = 0.1f;
    float coolTIme = 0f;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        memoryPools = new GameObject("MemoryPools");
    }

    // Update is called once per frame
    void Update()
    {
        coolTIme += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            if(coolTIme > interval)
            {
                coolTIme = 0f;
                GetMissile();
            }   
        }
    }

    void GetMissile()
    {
        for(int i = 0; i < missilePool.Count; i++)
        {
            if (!missilePool[i].activeSelf)
            {
                if(InfoManager.Instance.score >= 100)
                {
                    missilePool[i].gameObject.SetActive(true);
                    missilePool[i].transform.position = transform.position + new Vector3(0.2f, 1, 0);
                    missilePool[i+1].gameObject.SetActive(true);
                    missilePool[i+1].transform.position = transform.position + new Vector3(-0.2f, 1, 0);
                    return;
                }
                else
                {
                    missilePool[i].gameObject.SetActive(true);
                    missilePool[i].transform.position = transform.position + new Vector3(0, 1, 0);
                    return;
                }
            }
        }
        if(InfoManager.Instance.score >= 100)
        {
            GameObject obj = Instantiate(missile);
            GameObject obj2 = Instantiate(missile);

            obj.transform.position = transform.position + new Vector3(0.2f, 1, 0);
            obj.transform.parent = memoryPools.transform;
            obj2.transform.position = transform.position + new Vector3(-0.2f, 1, 0);
            obj2.transform.parent = memoryPools.transform;
            missilePool.Add(obj);
            missilePool.Add(obj2);
        }
        else
        {
            GameObject obj = Instantiate(missile);

            obj.transform.position = transform.position + new Vector3(0, 1, 0);
            obj.transform.parent = memoryPools.transform;
            missilePool.Add(obj);
        }
    }
}
