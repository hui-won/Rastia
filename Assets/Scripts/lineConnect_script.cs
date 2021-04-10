using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Runtime.ExceptionServices;

public class lineConnect_script : MonoBehaviour
{
    public GameObject starObj;
    public GameObject carObj;
    public GameObject keyObj;
    public GameObject carrotObj;
    public GameObject boatObj;
    public Button[] dot;
    public Text[] dot_text;

    public GameObject returnPanel;
    public Button returnBtn;

    public GameObject starImgPanel;
    public GameObject carImgPanel;
    public GameObject keyImgPanel;
    public GameObject carrotImgPanel;
    public GameObject boatImgPanel;
    private LineRenderer line;
    private List<Vector3> dotPos = new List<Vector3>();
    public GameObject settingPannel;
    font_script font;
    bool pannel1Clicked = false;
    bool pannel2Clicked = false;

    int Img;
    int character;
    /*
     * 1. 숫자
     * 2. 한글 자음
     * 3. 알파벳 대문자
     * 4. 알파벳 소문자
     */
    string[] imgName = { "star", "car", "key", "carrot", "boat" };
    int[] pointNum = { 10, 13, 18, 14, 13 };
    char[] koreanConsonant = { 'ㄱ', 'ㄴ', 'ㄷ', 'ㄹ', 'ㅁ', 'ㅂ', 'ㅅ', 'ㅇ', 'ㅈ', 'ㅊ', 'ㅋ', 'ㅌ', 'ㅍ', 'ㅎ' };

    int beforeSelectDot = 0;

    //랜덤으로 선택된 문자의 종류에 따라 출력되는 문자 설정
    void setCharacter(int cNum, int pNum, string iName)
    {
        string textObjName = iName + "_text";
        dot_text = new Text[pNum];
        for (int i = 0; i < pNum; i++)
        {
            dot_text[i] = GameObject.Find(textObjName + (i + 1).ToString()).GetComponent<Text>();
        }
        switch (cNum)
        {
            case 0: // 숫자
                for (int i = 0; i < pNum; i++)
                {
                    dot_text[i].text = (i + 1).ToString();
                }
                break;
            case 1: // 한글 자음

                for (int i = 0; i < pNum; i++)
                {
                    dot_text[i].text += koreanConsonant[i];
                }
                break;
            case 2: // 알파벳 대문자
                for (int i = 0; i < pNum; i++)
                {
                    int tmp = (int)'A';
                    tmp += i;
                    dot_text[i].text += Convert.ToChar(tmp);
                }
                break;
            case 3: // 알바벳 소문자
                for (int i = 0; i < pNum; i++)
                {
                    int tmp = (int)'a';
                    tmp += i;
                    dot_text[i].text += Convert.ToChar(tmp);
                }
                break;
            default:
                for (int i = 0; i < pNum; i++)
                {
                    dot_text[i].text = (i + 1).ToString();
                }
                break;
        }
    }

    private void setLineVector()
    {
        line.positionCount = dotPos.Count;
        line.SetPositions(dotPos.ToArray());
    }

    private void startLineRendering()
    {
        line = GetComponent<LineRenderer>();
        line.startWidth = 0.1f;
        line.endWidth = 0.1f;

        setLineVector();
    }

    private void setImg(int iNum)
    {
        switch (iNum)
        {
            case 0:
                starObj.SetActive(true);
                break;
            case 1:
                carObj.SetActive(true);
                break;
            case 2:
                keyObj.SetActive(true);
                break;
            case 3:
                carrotObj.SetActive(true);
                break;
            case 4:
                boatObj.SetActive(true);
                break;
            default:
                starObj.SetActive(true);
                break;
        }
    }

    private void selectSrc()
    {
        Img = UnityEngine.Random.Range(0, 5);

        character = UnityEngine.Random.Range(0, 4);
        if (character == 1 && pointNum[Img] > 14) character++;  //img의 점 갯수가 14보다 큰데 한글 자음나오면 다시 뽑음
        Debug.Log("random img and character selected");
    }

    IEnumerator wrongDot()
    {
        line.startColor = Color.red;
        line.endColor = Color.red;
        yield return new WaitForSeconds(0.1f);
        dotPos.RemoveAt(dotPos.Count - 1);
        line.startColor = Color.black;
        line.endColor = Color.black;
        setLineVector();
    }

    IEnumerator rightDot()
    {
        line.startColor = Color.green;
        line.endColor = Color.green;
        yield return new WaitForSeconds(0.1f);
        line.startColor = Color.black;
        line.endColor = Color.black;
    }

    private void dotClickListener(int dNum)
    {
        if (beforeSelectDot + 1 == dNum)
        {
            Debug.Log("right" + dNum);
            if (beforeSelectDot != 0)
            {
                dotPos.Add(setDotVec(dot[dNum - 1]));
                setLineVector();
            }
            StartCoroutine(rightDot());
            beforeSelectDot = dNum;
            if (dNum == pointNum[Img])
            {
                switch (Img)
                {
                    case 0:
                        starImgPanel.SetActive(true);
                        break;
                    case 1:
                        carImgPanel.SetActive(true);
                        break;
                    case 2:
                        keyImgPanel.SetActive(true);
                        break;
                    case 3:
                        carrotImgPanel.SetActive(true);
                        break;
                    case 4:
                        boatImgPanel.SetActive(true);
                        break;
                    default:
                        starImgPanel.SetActive(true);
                        break;
                }
            }
        }
        else
        {
            Debug.Log("wrong" + dNum);
            dotPos.Add(setDotVec(dot[dNum - 1]));
            setLineVector();
            StartCoroutine(wrongDot());
        }
    }

    //private void imgPanelFadeIn()
    //{
    //    if(fadeIsPlaying == true)   //중복 재생 방지
    //    {
    //        return;
    //    }
    //    StartCoroutine();
    //    starImgPanel.SetActive(true);
    //}

    //IEnumerator FadeIn()
    //{
    //    for(float i = 1f; i>=0; i -= 0f)
    //    {
    //        Color color = new Vector4(1, 1, 1, i);
    //        transform.renderer.material.color = color;
    //        yield return 0;
    //    }
    //}

    private Vector3 setDotVec(Button selectDot)
    {
        Vector3 tmpVec = selectDot.transform.position;
        tmpVec.z = 0.0f;
        return tmpVec;
    }

    public void endButtonOnClick()
    {
        SceneManager.LoadScene("scene06_game");
    }

    public void moreButtonOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void returnBtnOnClicked()
    {
        Debug.Log("return Button Clicked");

        for(int i=0; i<pointNum[Img]; i++)
        {
            dot[i].interactable = false;
        }
        returnPanel.SetActive(true);
        line.forceRenderingOff = true;
        if(!pannel2Clicked){
            font.getPannel2OriginSize();
            pannel2Clicked = true;
        }
        font.setPannel2FontSize();
    }

    public void yesBtnOnClicked()
    {
        SceneManager.LoadScene("scene09_01_lineConnect_main");
    }

    public void noBtnOnClicked()
    {
        returnPanel.SetActive(false);

        for (int i = 0; i < pointNum[Img]; i++)
        {
            dot[i].interactable = true;
        }
        line.forceRenderingOff = false;
    }

    public void settingButtonOnClick()
    {
        returnBtn.interactable = false;
        settingPannel.SetActive(true);
        switch (Img)
        {
            case 0:
                starObj.SetActive(false);
                break;
            case 1:
                carObj.SetActive(false);
                break;
            case 2:
                keyObj.SetActive(false);
                break;
            case 3:
                carrotObj.SetActive(false);
                break;
            case 4:
                boatObj.SetActive(false);
                break;
            default:
                starObj.SetActive(false);
                break;
        }
        line.forceRenderingOff = true;
        if(!pannel1Clicked){
            font.getPannel1OriginSize();
            pannel1Clicked = true;
        }
        font.setPannel1FontSize();
    }

    public void settingReturnButtonOnClick()
    {
        returnBtn.interactable = true;
        settingPannel.SetActive(false);
        switch (Img)
        {
            case 0:
                starObj.SetActive(true);
                break;
            case 1:
                carObj.SetActive(true);
                break;
            case 2:
                keyObj.SetActive(true);
                break;
            case 3:
                carrotObj.SetActive(true);
                break;
            case 4:
                boatObj.SetActive(true);
                break;
            default:
                starObj.SetActive(true);
                break;
        }
        line.forceRenderingOff = false;
        font.setFontSize();
    }

    public void fontSizePlusBtnClicked()
    {
        font.setFontPlus();
        font.setPannel1FontSize();
    }

    public void fontSizeMinusBtnClicked()
    {
        font.setFontMinus();
        font.setPannel1FontSize();
    }


    // Start is called before the first frame update
    void Start()
    {
        font = GameObject.Find("fontManager").GetComponent<font_script>();

        //Img = 4;
        //character = UnityEngine.Random.Range(0, 4);
        selectSrc();
        setImg(Img);

        setCharacter(character, pointNum[Img], imgName[Img]);

        dot = new Button[pointNum[Img]];
        for (int i = 0; i < pointNum[Img]; i++)
        {
            dot[i] = GameObject.Find("dot_" + imgName[Img] + (i + 1).ToString()).GetComponent<Button>();
            int _i = i;
            dot[i].onClick.AddListener(() => dotClickListener(_i + 1));
        }

        dotPos.Add(setDotVec(dot[pointNum[Img] - 1]));
        dotPos.Add(setDotVec(dot[0]));

        startLineRendering();

        Debug.Log("start rendering complete");
        font.getOriginSize();
        font.setFontSize();
    }

    // Update is called once per frame
    void Update()
    {
    }

}