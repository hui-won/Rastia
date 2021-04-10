using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class familytest_slider : MonoBehaviour
{
    public Slider[] A = new Slider[15];
    static public float[] val = new float[15];
    public int where = -1;
   

    void Start()
    {
        Variables.fsum = 0;
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

        Variables.fsum = sum;
        Debug.Log(Variables.fsum);

        if (Variables.fsum >= 10)
        {
            Variables.where = 1;
        }
        else if (Variables.fsum >= 0 && Variables.fsum < 10)
        {
            Variables.where = 0;
        }
        Variables.whoami = 20;
    }

}
