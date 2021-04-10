using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sjhline : MonoBehaviour
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
    public void gameStartBtnOnClicked()
    {
        Debug.Log("gameStart Button Clicked");
        SceneManager.LoadScene("SampleScene");
    }

    public void returnBtnOnClicked()
    {
        Debug.Log("return Button Clicked");
        SceneManager.LoadScene("scene06_game");
    }

    public void methodBtnOnClicked()
    {
        Debug.Log("method Button Clicked");
        SceneManager.LoadScene("method");
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
}
