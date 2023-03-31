using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score : " + InfoManager.Instance.score.ToString() 
            + "\nBestScore : " + PlayerPrefs.GetInt("Score");
        InfoManager.Instance.score = 0;
    }

    public void TitleButton()
    {
        SceneManager.LoadScene("Main");
    }
    public void RetryButton()
    {
        SceneManager.LoadScene("Game");
    }
}
