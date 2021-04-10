//mole_game
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class mole_game : MonoBehaviour
{
    public GameObject endPanel;
    public GameObject gameScreen;
    public GameObject returnPanel;
    
    public Text timer;
    public Button returnButton;
    public Button yesButton;
    public Button noButton;

    public int g_cnt;//착한 두더지 잡은 횟수
    public int b_cnt;//나쁜 두더지 잡은 횟수
    public int total_score;//전체 점수

    public Text score1;//실시간 점수판
    public Text score2;//최종 점수판

    public static float time;

    public bool isReturnBtnClicked = false;
    public bool areyouing = true;

    font_script font;
    // Start is called before the first frame update
    bool fontSet1 = false;
    bool fontset2 = false;
    public void Start()
    {
        font = GameObject.Find("fontManager").GetComponent<font_script>();
        font.getOriginSize();
        font.setFontSize();
        total_score = 0;
        closePanels();
        time = 15f;
       
        g_cnt = 0;
        b_cnt = 0;
    }

   

    // Update is called once per frame
    void Update()
    {
        if(time != 0)
        {
            areyouing = true;
            if (isReturnBtnClicked == false)
            {   
                time -= Time.deltaTime;
            }
            else
            {
                returnPanel.SetActive(true);
                gameScreen.SetActive(false);
                if(!fontSet1){
                    font.getPannel1OriginSize();
                    font.setPannel1FontSize();
                    fontSet1 = true;
                }
            }
            if (time <= 0)
            {
                time = 0;
            }
        }
        int t = Mathf.FloorToInt(time);
        
        timer.text = time.ToString();

        if (time == 0)
        {
            showEndPanel();
            isReturnBtnClicked = false;
            areyouing = false;
        }

        total_score = (g_cnt * 10) - (b_cnt * 5);
        Debug.Log(total_score);
        score1.text = total_score.ToString();
    }
    void showEndPanel()
    {
        endPanel.SetActive(true);
        gameScreen.SetActive(false);

        //Debug.Log(total_score);
        score2.text = total_score.ToString();
        if(!fontset2){
            font.getPannel2OriginSize();
            font.setPannel2FontSize();
            fontset2 = true;
        }
    }
    void closePanels()
    {
        endPanel.SetActive(false);
        returnPanel.SetActive(false);
        gameScreen.SetActive(true);
    }

    public void returnButtonOnClicked()
    {
        if (areyouing == true)
        {
            isReturnBtnClicked = true;
        }
        else
        {
            SceneManager.LoadScene("mole1");
        }
    }

    public void yesButtonOnClicked()
    {
        SceneManager.LoadScene("mole1");
    }
    public void noButtonOnClicked()
    {
        isReturnBtnClicked = false;
        closePanels();
       // gameScreen.SetAcitve(true);
    }
}
