using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class answerw : MonoBehaviour
{
    private int result;
    public GameObject but0;
    public GameObject but1;
    public GameObject but2;
    public GameObject but3;
    public GameObject but4;
    public GameObject but5;
    public GameObject but6;
    public Text ansans; 
    private int rree;

    font_script font;
    // Start is called before the first frame update
    void Start()
    {
        font = GameObject.Find("fontManager").GetComponent<font_script>();
        font.getOriginSize();
        font.setFontSize();
        ansans.gameObject.SetActive(false);
        but5.SetActive(false);
        but6.SetActive(false);
        result = clam.dataa;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void checkAnswer0()
    {
        rree=0;
        but0.SetActive(false);
        but1.SetActive(false);
        but2.SetActive(false);
        but3.SetActive(false);
        but4.SetActive(false);
        but5.SetActive(true);
        but6.SetActive(true);
        ansans.gameObject.SetActive(true);
        if(rree==result)
        {
            ansans.text = "정답!!!";
        }else{
            ansans.text = "땡~~~ 답은"+result;
        }

    }
    public void checkAnswer1()
    {
        rree=1;
        but0.SetActive(false);
        but1.SetActive(false);
        but2.SetActive(false);
        but3.SetActive(false);
        but4.SetActive(false);
        but5.SetActive(true);
        but6.SetActive(true);
        ansans.gameObject.SetActive(true);
        if(rree==result)
        {
            ansans.text = "정답!!!";
        }else{
            ansans.text = "땡~~~ 답은"+result;
        }

    }
    public void checkAnswer2()
    {
        rree=2;
        but0.SetActive(false);
        but1.SetActive(false);
        but2.SetActive(false);
        but3.SetActive(false);
        but4.SetActive(false);
        but5.SetActive(true);
        but6.SetActive(true);
        ansans.gameObject.SetActive(true);
        if(rree==result)
        {
            ansans.text = "정답!!!";
        }else{
            ansans.text = "땡~~~답은"+result;
        }

    }
    public void checkAnswer3()
    {
        rree=3;
        but0.SetActive(false);
        but1.SetActive(false);
        but2.SetActive(false);
        but3.SetActive(false);
        but4.SetActive(false);
        but5.SetActive(true);
        but6.SetActive(true);
        ansans.gameObject.SetActive(true);
        if(rree==result)
        {
            ansans.text = "정답!!!";
        }else{
            ansans.text = "땡~~~답은"+result;
        }

    }
    public void checkAnswer4()
    {
        rree=4;
        but0.SetActive(false);
        but1.SetActive(false);
        but2.SetActive(false);
        but3.SetActive(false);
        but4.SetActive(false);
        but5.SetActive(true);
        but6.SetActive(true);
        ansans.gameObject.SetActive(true);
        if(rree<=result)
        {
            ansans.text = "정답!!!";
        }else{
            ansans.text = "땡~~~답은"+result;
        }

    }
    public void changeScene()
    {
        SceneManager.LoadScene("line");
    }
    public void returnBtnOnClick()
    {
        Debug.Log("return Button Clicked");
        SceneManager.LoadScene("scene06_game");
    }
}
