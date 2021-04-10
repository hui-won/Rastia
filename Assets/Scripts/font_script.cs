using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class font_script : MonoBehaviour
{
    public static font_script instance = null;
    public int fontSize = 0;
    private int maxFont = 10;
    private int smallestFont = -10;
    
    Text[] tmp{
        get{
            return GameObject.FindObjectsOfType<Text>();
        }
    }
       Text[] tmp_pannel1{
        get{
            return GameObject.FindObjectsOfType<Text>();
        }
    }
    Text[] tmp_pannel2{
        get{
            return GameObject.FindObjectsOfType<Text>();
        }
    }
    int[] originSize;
    int[] originPannel1Size;
    int[] originPannel2Size;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);

    }

    public void getOriginSize(){
        originSize = new int[tmp.Length];
        for(int i=0; i<tmp.Length; i++){
            originSize[i] = tmp[i].fontSize;
        }
    }

    public void getPannel1OriginSize(){
        originPannel1Size = new int[tmp_pannel1.Length];
        for(int i=0; i<tmp_pannel1.Length; i++){
            originPannel1Size[i] = tmp_pannel1[i].fontSize;
        }
    }
    public void getPannel2OriginSize(){
        originPannel2Size = new int[tmp_pannel2.Length];
        for(int i=0; i<tmp_pannel2.Length; i++){
            originPannel2Size[i] = tmp_pannel2[i].fontSize;
        }
    }
    public void setFontSize()
    {
        for(int i=0; i<tmp.Length; i++){
            tmp[i].fontSize = originSize[i] + fontSize;
        }
    }

    public void setPannel1FontSize()
    {
        for(int i=0; i<tmp_pannel1.Length; i++){
            tmp_pannel1[i].fontSize = originPannel1Size[i] + fontSize;
        }
    }
    
    public void setPannel2FontSize()
    {
        for(int i=0; i<tmp_pannel2.Length; i++){
            tmp_pannel2[i].fontSize = originPannel2Size[i] + fontSize;
        }
    }

    public void setFontPlus(){
        if(fontSize >= maxFont)
               return;
        fontSize += 1;
    }
    
    public void setFontMinus(){
        if(fontSize <= smallestFont)
            return;
        fontSize -= 1;
    }

}
