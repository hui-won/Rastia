/*test_result*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class test_result : MonoBehaviour
{

   
    public Text score_display;//점수판
    public Text comment1;//진단 결과1
    public Text comment2;//진단 결과2

    font_script font;

    // Start is called before the first frame update
    void Start()
    {
        font = GameObject.Find("fontManager").GetComponent<font_script>();
        float score = 0;//점수 받기
        comment1.text = "걱정 마세요. 6점 이상부터 위험해요.";
        if (Variables.whoami == 10)
        {
            score = Variables.ssum;
            if (Variables.where == 0)
            {
                comment1.text = "걱정 마세요. 6점 이상부터 위험해요.";
            }
             if (Variables.where == 1)
            {
                comment1.text = "주의하세요. 6점 이상부터 위험해요!";
            }
        }
        else if (Variables.whoami == 20)
        {
            score = Variables.fsum;
            if (Variables.where == 0)
            {
                comment1.text = "걱정 마세요. 10점이상부터 위험해요.";
            }
            else if (Variables.where == 1)
            {
                comment1.text = "주의하세요. 10점 이상부터 위험해요!";
            }
        }
        score_display.text = score.ToString();
        print_comment2();
        
        font.getOriginSize();
        font.setFontSize();
    }
    void print_comment2()
    {
        
        switch (UnityEngine.Random.Range(1, 5))
        {
            case 1:
                comment2.text = "오늘 저녁 가벼운 산책 어때요?"+"\n"+"산책은 뇌를 효율적으로 만들어요.";
                break;
            case 2:
                comment2.text = "샤워할 때 노래를 불러보세요!" + "\n" + "뇌파안정에 효과적인 방법이 음악이랍니다.";
                break;
            case 3:
                comment2.text = "잠을 푹 주무세요." + "\n" + "적정 시간의 숙면은 치매 위험 요소를 줄이고 뇌의 컨디션에 도움을 준답니다.";
                break;
            case 4:
                comment2.text = "명상을 해볼까요?" + "\n" + "단 2분만으로 혈액순환 개선에 도움을 준답니다.";
                break;
            case 5:
                comment2.text = "운동을 해볼까요?" + "\n" + "요가나 스트레칭같은 가벼운 운동만으로도 뇌의 신경세포의 생존을 촉진시킬수 있어요.";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
