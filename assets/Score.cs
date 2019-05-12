using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText; //Text用変数
    private int score = 0; //スコア計算用変数

    // Use this for initialization
    void Start()
    {
        score = 0;
    }
    void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "SmallStarTag")
        {
            score += 10;
        }
        else if (yourTag == "LargeStarTag")
        {
            score += 50;
        }
        else if (yourTag == "SmallCloudTag")
        {
            score += 30;
        }
        else if (yourTag == "LargeCloudTag")
        {
            score += 100;
        }

        SetScore();
    }

    void SetScore()
    {
        scoreText.text = string.Format("スコア:{0}", score);
    }
}
