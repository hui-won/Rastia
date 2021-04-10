using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class soramethod : MonoBehaviour
{
    public GameObject obj;
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

    public void settingButtonOnClick()
    {
        settingPannel.SetActive(true);
        obj.SetActive(false);
        if(!pannel1Clicked){
            font.getPannel1OriginSize();
            pannel1Clicked = true;
        }
        font.setPannel1FontSize();
    }

    public void settingReturnButtonOnClick()
    {
        settingPannel.SetActive(false);
        obj.SetActive(true);
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

    public void retBtnOnClicked()
    {
        Debug.Log("return Button Clicked");
        SceneManager.LoadScene("line");
    }
}
