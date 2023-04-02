using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoManager : MonoBehaviour
{
    #region singleton
    private static InfoManager s_instance = null;
    public static InfoManager Instance 
    {
        get 
        { 
            if(s_instance == null)
                return null;
            return s_instance; 
        } 
    }

    private void Awake()
    {
        if(s_instance == null) 
        {
            s_instance = this;
            //no delete, if scene are changing
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //if duplicated
            Destroy(gameObject);
        }
    }
    #endregion

    const float maxHp = 5;

    private int s_score = 0;

    public int Hp = 5;

    public Image HpGauge;

    public GameObject effect;
    public GameObject money;
    public GameObject hpPack;
    public GameObject player;

    public float meteorPosY;

    public List<GameObject> goldPool = new List<GameObject>();
    GameObject goldMemory;

    private void Start()
    {
        goldMemory = new GameObject("GoldPools");
    }

    public int score
    {
        get { return s_score; }
        set
        {
            s_score = value;
            if(s_score > PlayerPrefs.GetInt("score"))
            {
                PlayerPrefs.SetInt("score", s_score);
            }
        }
    }

    public void MakeMoney(Transform target, int count)
    {
        Debug.Log("Make Gold : " + count);
        while(count > 0)
        {
            GetGold(target);
            count--;
        }
    }

    public void UpdateHP()
    {
        HpGauge.fillAmount = Hp / maxHp;
    }

    public void MakeHpPack(Transform target)
    {
        if(Random.Range(0, 3) == 2)
        {
            Instantiate(hpPack, target.position, Quaternion.identity);
        }
    }

    public void GetGold(Transform target)
    {
        for (int i = 0; i < goldPool.Count; i++)
        {
            if (!goldPool[i].activeSelf)
            {
                goldPool[i].gameObject.SetActive(true);
                goldPool[i].transform.position = target.position;
                return;
            }
        }
        GameObject obj = Instantiate(money, target.position, Quaternion.identity, goldMemory.transform);
        goldPool.Add(obj);
    }

    public void CreateEffect(Transform target)
    {
        Instantiate(effect, target.position, Quaternion.identity);
    }

    public void SetMetorPos(float meteorposY)
    {
        meteorPosY = meteorposY;
    }

}
