using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lineConnectMethod_script : MonoBehaviour
{
    public GameObject lineConnectMethodObj;
    public GameObject settingPannel;
    font_script font;
    bool pannel1Clicked = false;

    public void returnBtnOnClicked()
    {
        Debug.Log("return Button Clicked");
        SceneManager.LoadScene("scene09_01_lineConnect_main");
    }

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

    public void settingButtonOnClick()
    {
        settingPannel.SetActive(true);
        lineConnectMethodObj.SetActive(false);
        if(!pannel1Clicked){
            font.getPannel1OriginSize();
            pannel1Clicked = true;
        }
        font.setPannel1FontSize();
    }

    public void settingReturnButtonOnClick()
    {
        settingPannel.SetActive(false);
        lineConnectMethodObj.SetActive(true);
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
