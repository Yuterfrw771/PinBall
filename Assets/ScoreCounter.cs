using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private GameObject scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
        this.scoreText.GetComponent<Text>().text = "0";
    }


    // Update is called once per frame
    void Update()
    {
       
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collosion)
    {
        //衝突した相手のTagを取得し判定
        if (collosion.gameObject.CompareTag("LargeCloudTag"))
        {
            //スコアを1000点加算
            this.score += 1000;
            //スコアを表示
            this.scoreText.GetComponent<Text>().text = score.ToString();
        }
        else if (collosion.gameObject.CompareTag("SmallCloudTag"))
        {
            //スコアを100点加算
            this.score += 100;
            //スコアを表示
            this.scoreText.GetComponent<Text>().text = score.ToString();
        }
        else if (collosion.gameObject.CompareTag("LargeStarTag"))
        {
            //スコアを500点加算
            this.score += 500;
            //スコアを表示
            this.scoreText.GetComponent<Text>().text = score.ToString();
        }
        else if(collosion.gameObject.CompareTag("SmallStarTag"))
        {
            //スコアを10点加算
            this.score += 10;
            //スコアを表示
            this.scoreText.GetComponent<Text>().text = score.ToString();
        }

    }

}
