using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfTestSetting_script : MonoBehaviour
{
    public GameObject testPanel;
    public GameObject settingPannel;
    font_script font;
    // Start is called before the first frame update
    void Start()
    {
        font = GameObject.Find("fontManager").GetComponent<font_script>();
        font.getOriginSize();
        //font.setFontSize();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void settingButtonOnClick()
    {
        settingPannel.SetActive(true);
        testPanel.SetActive(false);
    }

    public void settingReturnButtonOnClick()
    {
        settingPannel.SetActive(false);
        testPanel.SetActive(true);
        font.setFontSize();
    }

    public void fontSizePlusBtnClicked()
    {
        font.setFontPlus();
    }

    public void fontSizeMinusBtnClicked()
    {
        font.setFontMinus();
    }

}
