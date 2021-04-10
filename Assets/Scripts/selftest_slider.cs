using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class selftest_slider : MonoBehaviour
{
    public Slider[] A = new Slider[15];
    static public float[] val = new float[15];
   

    void Start()
    {
        Variables.ssum = 0;
    }

    public void SliderResult()
    {
        for (int i = 0; i < 15; i++)
        {
            val[i] = A[i].value;
        }
        float sum = 0;

        for (int i = 0; i < 15; i++)
        {
            sum += val[i];
        }

       
        Variables.ssum = sum;
        Debug.Log(Variables.ssum);

        if (Variables.ssum >= 6)
        {
            Variables.where = 1;
        }
        else if(Variables.ssum >= 0 && Variables.ssum < 6){
            Variables.where = 0;
        }
        Variables.whoami = 10;
    }

 
}
