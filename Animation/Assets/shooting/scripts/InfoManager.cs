using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private int s_score = 0;
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

    public GameObject money;

    public void MakeMoney(Transform target, int count)
    {
        while(count > 0)
        {
            Instantiate(money, target.position, Quaternion.identity);
            count--;
        }
    }

    public GameObject effect;

    public void CreateEffect(Transform target)
    {
        Instantiate(effect, target.position, Quaternion.identity);
    }
}
