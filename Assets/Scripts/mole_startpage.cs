//mole_startpage
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mole_startpage : MonoBehaviour
{
    public Button howtoButton;
    public GameObject mainpage;
    public GameObject explaPanel;
    public GameObject settingPannel;
    font_script font;
    bool pannel1Clicked = false;
    // Start is called before the first frame update
    void Start()
    {
        font = GameObject.Find("fontManager").GetComponent<font_script>();
        closeHowto();
        font.getOriginSize();
        font.setFontSize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showHowto()
    {
        explaPanel.SetActive(true);
        mainpage.SetActive(false);
    }
    public void closeHowto()
    {
        explaPanel.SetActive(false);
        mainpage.SetActive(true);
    }
    public void settingButtonOnClick()
    {
        settingPannel.SetActive(true);
        mainpage.SetActive(false);
        if(!pannel1Clicked){
            font.getPannel1OriginSize();
            pannel1Clicked = true;
        }
        font.setPannel1FontSize();
    }

    public void settingReturnButtonOnClick()
    {
        settingPannel.SetActive(false);
        mainpage.SetActive(true);
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
