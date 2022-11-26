using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{

    //[SerializeField]
    public static int score = 0; // static : 클래스 단위로 공통적으로 사용하는 변수 . 인스턴스 단위에서 관리 ㄴ. 인스 턴스 생성 없이 클래스 수준에서 사용 가능 .
    public static int bestScore = 0; // static : 클래스 단위로 공통적으로 사용하는 변수 . 인스턴스 단위에서 관리 ㄴ. 인스 턴스 생성 없이 클래스 수준에서 사용 가능 .


    void Start()
    {
        score = 0;
    }

    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
