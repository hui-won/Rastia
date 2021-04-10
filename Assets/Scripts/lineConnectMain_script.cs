using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lineConnectMain_script : MonoBehaviour
{
    public GameObject lineConnectSceneObj;
    public GameObject settingPannel;
    font_script font;
    bool pannel1Clicked = false;
    // Start is called before the first frame update
    void Start()
    {
        font = GameObject.Find("fontManager").GetComponent<font_script>();
        font.getOriginSize();
        font.setFontSize();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void gameStartBtnOnClicked()
    {
        Debug.Log("gameStart Button Clicked");
        SceneManager.LoadScene("scene09_02_lineConnect_game");
    }

    public void returnBtnOnClicked()
    {
        Debug.Log("return Button Clicked");
        SceneManager.LoadScene("scene06_game");
    }

    public void methodBtnOnClicked()
    {
        Debug.Log("method Button Clicked");
        SceneManager.LoadScene("scene09_03_lineConnect_method");
    }

    public void settingButtonOnClick()
    {
        settingPannel.SetActive(true);
        lineConnectSceneObj.SetActive(false);
        if(!pannel1Clicked){
            font.getPannel1OriginSize();
            pannel1Clicked = true;
        }
        font.setPannel1FontSize();
    }
    public void settingReturnButtonOnClick()
    {
        settingPannel.SetActive(false);
        lineConnectSceneObj.SetActive(true);
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

}
