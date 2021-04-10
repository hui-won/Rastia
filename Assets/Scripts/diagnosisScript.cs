//diagnosisScripts.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class diagnosisScript : MonoBehaviour
{
    public GameObject diagnosisSceneObj;
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

    public void returnButtonOnClick()
    {
        Debug.Log("returnButtonClicked");
        SceneManager.LoadScene("scene01_Main");
    }

    public void aloneButtonOnClick()
    {
        Debug.Log("aloneButtonClicked");
        SceneManager.LoadScene("scene03_alone");
    }

    public void togetherButtonOnClick()
    {
        Debug.Log("togetherButtonClicked");
        SceneManager.LoadScene("scene04_family");
    }

    public void settingButtonOnClick()
    {
        settingPannel.SetActive(true);
        diagnosisSceneObj.SetActive(false);
        if(!pannel1Clicked){
            font.getPannel1OriginSize();
            pannel1Clicked = true;
        }
        font.setPannel1FontSize();
    }

    public void settingReturnButtonOnClick()
    {
        settingPannel.SetActive(false);
        diagnosisSceneObj.SetActive(true);
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
