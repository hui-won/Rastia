//game_scripts.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class game_script : MonoBehaviour
{
    public GameObject gameSceneObj;
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

    public void returnBtnOnClick()
    {
        Debug.Log("return Button Clicked");
        SceneManager.LoadScene("scene01_Main");
    }
    public void game1BtnOnClick()
    {
        Debug.Log("game1 Button Clicked");
        SceneManager.LoadScene("mole1");
    }
    public void game2BtnOnClick()
    {
        Debug.Log("game2 Button Clicked");
        SceneManager.LoadScene("line");
    }
    public void game3BtnOnClick()
    {
        Debug.Log("game3 Button Clicked");
        SceneManager.LoadScene("scene09_01_lineConnect_main");
    }

    public void settingButtonOnClick()
    {
        settingPannel.SetActive(true);
        gameSceneObj.SetActive(false);
        if(!pannel1Clicked){
            font.getPannel1OriginSize();
            pannel1Clicked = true;
        }
        font.setPannel1FontSize();
    }

    public void settingReturnButtonOnClick()
    {
        settingPannel.SetActive(false);
        gameSceneObj.SetActive(true);
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
