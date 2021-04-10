//main_scripts.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class main_script : MonoBehaviour
{
    public Button closeBtn;
    public GameObject closePannel;
    public GameObject mainObj;
    public GameObject settingPannel;

    font_script font;

    bool pannel1Clicked = false;
    bool pannel2Clicked = false;

    // Start is called before the first frame update
    void Start()
    {
        font = GameObject.Find("fontManager").GetComponent< font_script >();
        closeBtn.onClick.AddListener(showCloseBox);
        font.getOriginSize();
        font.setFontSize();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void showCloseBox()
    {
        closePannel.SetActive(true);
        mainObj.SetActive(false);
        if(!pannel2Clicked){
            font.getPannel2OriginSize();
            pannel2Clicked = true;
        }
        font.setPannel2FontSize();
    }

    void Quit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void yesButtonOnClick()
    {
        Debug.Log("yesButtonClicked");
        Quit();
    }

    public void noButtonOnClick()
    {
        Debug.Log("noButtonClicked");
        closePannel.SetActive(false);
        mainObj.SetActive(true);
    }

    public void diagnosisButtonClicked()
    {
        Debug.Log("diagnosisButtonClicked");
        SceneManager.LoadScene("scene02_diagnosis");
    }

    public void gameStartButtonClicked()
    {
        Debug.Log("gameStartButtonClicked");
        SceneManager.LoadScene("scene06_game");
    }

    public void settingButtonClicked()
    {
        Debug.Log("settingButtonClicked");
        mainObj.SetActive(false);
        settingPannel.SetActive(true);
        if(!pannel1Clicked){
            font.getPannel1OriginSize();
            pannel1Clicked = true;
        }
        font.setPannel1FontSize();
    }

    public void returnButtonClicked()
    {
        Debug.Log("returnButtonClicked");
        settingPannel.SetActive(false);
        mainObj.SetActive(true);
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
