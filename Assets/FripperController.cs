using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingleJointコンポーネントを入れる
    private HingeJoint myHingeJoint;

    //初期の傾き
    private float defaultAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;


    // Start is called before the first frame update
    void Start()
    {
        //HingleJointコンポーネントを入れる
        this.myHingeJoint = GetComponent<HingeJoint>();

        //フリッパーの傾きを設定
        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update()
    {
        //左矢印キーとAキーを押した時左フリッパーを動かす
        if ((Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.A)) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //右矢印キーとDキーを押した時右フリッパーを動かす
        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //Sキーと下↓で左右のフリッパーを動かす
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) && (tag == "RightFripperTag" || tag == "LeftFripperTag"))
        {
            SetAngle(this.flickAngle);
        }

        //左矢印キーとAキーを離した時左フリッパーを元に戻す
        if ((Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A)) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        //右矢印キーとDキーを離した時右フリッパーを動かす
        if ((Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D)) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        //Sキーと下↓で左右のフリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S) && (tag == "RightFripperTag" || tag == "LeftFripperTag"))
        {
            SetAngle(this.defaultAngle);
        }



    }

    //フリッパーの傾きを設定
    public void SetAngle (float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }

}
